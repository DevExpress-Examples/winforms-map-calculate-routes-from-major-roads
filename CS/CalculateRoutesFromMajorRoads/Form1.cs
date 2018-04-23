using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CalculateRoutesFromMajorRoads {
    public partial class Form1 : Form {

        double latitude;
        double longitude;
        string description = "Route Waypoint";
        const string yourBingKey = "INSERT_YOUR_BING_KEY_HERE";
        MapControl map;
        BingRouteOptions routeOptions = new BingRouteOptions();
        BingRouteDataProvider routeProvider = new BingRouteDataProvider();
        InformationLayer infoLayer;

        public Form1() {
            InitializeComponent();
            cbMode.SelectedIndex = 0;
            cbOptimize.SelectedIndex = 0;
            this.panel2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Call the PrepareMap method.
            PrepareMap();

            // Handle the BingRouteCalculated event.
            routeProvider.RouteCalculated +=
                new BingRouteCalculatedEventHandler(routeDataProvider_RouteCalculated);
        }

        private void calculateRoutes_Click(object sender, EventArgs e) {
            if (GetCalculateRoutesArguments()) {

                // Call the CalculateMajorRouteRequest method.             
                routeProvider.CalculateRoutesFromMajorRoads(new RouteWaypoint
                                  (description, new GeoPoint(latitude, longitude)));
            }
        }

        private bool GetCalculateRoutesArguments() {
            latitude = String.IsNullOrEmpty(tbLatitude.Text) ? 0 : Double.Parse(tbLatitude.Text);
            if ((latitude > 90) || (latitude < -90)) {
                MessageBox.Show("Latitude must be less than or equal to 90 and greater" +
                                 "than or equal to - 90. Correct the input value.");
                return false;
            }

            longitude = String.IsNullOrEmpty(tbLongitude.Text) ? 0 : Double.Parse(tbLongitude.Text);
            if ((longitude > 180) || (longitude < -180)) {
                MessageBox.Show("Longitude must be less than or equal to 180 and greater" +
                                "than or equal to - 180. Correct the input value.");
                return false;
            }

            routeProvider.RouteOptions.Mode = routeOptions.Mode;
            routeProvider.RouteOptions.RouteOptimization = routeOptions.RouteOptimization;

            if (cbMode.SelectedIndex == 0)
                routeOptions.Mode = BingTravelMode.Driving;
            else
                routeOptions.Mode = BingTravelMode.Walking;

            if (cbOptimize.SelectedIndex == 0)
                routeOptions.RouteOptimization = BingRouteOptimization.MinimizeTime;
            else
                routeOptions.RouteOptimization = BingRouteOptimization.MinimizeDistance;

            return true;
        }

        public void NavigateTo(GeoPoint geoPoint) {
            map.CenterPoint = geoPoint;
            map.ZoomLevel = 11;
        }

        private void routeDataProvider_RouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            RouteCalculationResult result = e.CalculationResult;
            StringBuilder resultList = new StringBuilder("");

            if (result.IntermediatePoints != null) {
                resultList.Append(String.Format("_________________________\n"));
                int i = 1;
                foreach (RouteWaypoint startingPoint in result.IntermediatePoints)
                    resultList.Append(String.Format("Starting point {0}: {1} ({2})\n", i++,
                        startingPoint.Description, startingPoint.Location));
            }

            if ((result.RouteResults != null) & (result.ResultCode == RequestResultCode.Success)) {
                NavigateTo(result.RouteResults[0].RoutePath[0]);

                int rnum = 1;
                foreach (BingRouteResult routeResult in result.RouteResults) {
                    resultList.Append(String.Format("_________________________\n"));
                    resultList.Append(String.Format("Path {0}:\n", rnum++));
                    resultList.Append(String.Format("Distance: {0}\n", routeResult.Distance));
                    resultList.Append(String.Format("Time: {0}\n", routeResult.Time));

                    if (routeResult.Legs != null) {
                        int legNum = 1;
                        foreach (BingRouteLeg leg in routeResult.Legs) {
                            resultList.Append(String.Format("\tLeg {0}:\n", legNum++));
                            resultList.Append(String.Format("\tDistance: {0}\n", leg.Distance));
                            resultList.Append(String.Format("\tTime: {0}\n", leg.Time));
                            if (leg.Itinerary != null) {
                                foreach (BingItineraryItem itineraryItem in leg.Itinerary) {
                                    resultList.Append(String.Format(itineraryItem.Maneuver + "\n"));
                                    resultList.Append(String.Format("\t\tLocation: {0}\n", itineraryItem.Location));
                                }
                            }
                        }
                    }
                }
            }

            if ((result.RouteResults == null) || (result.ResultCode == RequestResultCode.BadRequest))
                tbResults.Text = "The Bing Route service does not work for this location.";
            else tbResults.Text = resultList.ToString();
        }

        private void PrepareMap() {
            // Create a map control.
            map = new MapControl();

            // Specify the map position on the form.           
            map.Dock = DockStyle.Fill;

            // Add the map control to the window.
            this.Controls.Add(map);

            // Bring the map to the front.
            map.BringToFront();

            // Create an image tiles layer and add it to the map.
            ImageTilesLayer tilesLayer = new ImageTilesLayer();
            map.Layers.Add(tilesLayer);

            // Create an  information layer and add it to the map.
            infoLayer = new InformationLayer();
            map.Layers.Add(infoLayer);

            // Create a Bing data provider and specify the Bing key.
            BingMapDataProvider bingProvider = new BingMapDataProvider();
            tilesLayer.DataProvider = bingProvider;
            bingProvider.BingKey = yourBingKey;

            // Create a Bing route data provider and specify the Bing key.
            routeProvider = new BingRouteDataProvider();
            infoLayer.DataProvider = routeProvider;
            routeProvider.BingKey = yourBingKey;

            // Customize stroke and stroke width of a route.  
            infoLayer.ItemStyle.Stroke = Color.FromArgb(0xFF, 0x8A, 0xFB, 0xFF);
            infoLayer.ItemStyle.StrokeWidth = 4;
        }
    }
}

