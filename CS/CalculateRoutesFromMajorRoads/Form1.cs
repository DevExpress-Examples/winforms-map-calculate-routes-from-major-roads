using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace CalculateRoutesFromMajorRoads {
    public partial class Form1 : Form {
        const double minLat = -90;
        const double maxLat = 90;
        const double minLon = -180;
        const double maxLon = 180;

        const string yourBingKey = "Insert Your Bing Key Here";//"Your Bing Key";

        double lat = 40;
        double lon = -120;
        BingRouteDataProvider routeProvider;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            imageProvider.BingKey = yourBingKey;

            routeProvider = new BingRouteDataProvider { BingKey = yourBingKey };
            routeProvider.LayerItemsGenerating += OnLayerItemsGenerating;
            routeProvider.RouteCalculated += OnRouteCalculated;
            informationLayer.DataProvider = routeProvider;
            informationLayer.DataRequestCompleted += OnDataRequestCompleted;

            teLatitude.Text = lat.ToString();
            teLongitude.Text = lon.ToString();
            #region #InitBingRouteOptions
            cbeTravelMode.Properties.Items.AddRange(Enum.GetValues(typeof(BingTravelMode)));
            cbeTravelMode.SelectedIndex = 0;
            cbeRouteOptimization.Properties.Items.AddRange(Enum.GetValues(typeof(BingRouteOptimization)));
            cbeRouteOptimization.SelectedIndex = 0;
            #endregion #InitBingRouteOptions
        }

        #region #LayerItemsGenerating
        void OnLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            foreach(MapItem item in e.Items) {
                MapPolyline polyline = item as MapPolyline;
                if(polyline != null) {
                    polyline.Stroke = Color.FromArgb(0xFF, 0x00, 0x72, 0xC6);
                    polyline.StrokeWidth = 4;
                }
            }
        }
        #endregion #LayerItemsGenerating

        #region #DataRequestCompleted
        void OnDataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl.ZoomToFitLayerItems(0.4);
        }
        #endregion #DataRequestCompleted

        #region #BingRouteOptionsChanged
        private void OnTravelModeSelectedIndexChanged(object sender, EventArgs e) {
            routeProvider.RouteOptions.Mode = (BingTravelMode)cbeTravelMode.SelectedItem;
        }

        private void OnRouteOptimizationSelectedIndexChanged(object sender, EventArgs e) {
            routeProvider.RouteOptions.RouteOptimization = (BingRouteOptimization)cbeRouteOptimization.SelectedItem;
        }
        #endregion #BingRouteOptionsChanged

        void ShowErrorMessage(string variable, double minVal, double maxVal) {
            MessageBox.Show(
                        this,
                        String.Format(
                            "The {0} value shoud be larger or equals {1} and less or equals {2}.",
                            variable,
                            minVal,
                            maxVal
                        ),
                        variable
                    );
        }

        private void OnLatitudeValidating(object sender, CancelEventArgs e) {
            if(!Double.TryParse(teLatitude.Text, out lat) ||
                (lat > maxLat) || (lat < minLat)) {
                e.Cancel = true;
                ShowErrorMessage("Latitude", minLat, maxLat);
            }
        }

        private void OnLongitudeValidating(object sender, CancelEventArgs e) {
            if(!Double.TryParse(teLongitude.Text, out lon) ||
                (lon > maxLon) || (lon < minLon)) {
                e.Cancel = true;
                ShowErrorMessage("Longitude", minLon, maxLon);
            }
        }

        private void OnCalculateRoutesClick(object sender, EventArgs e) {
            RouteWaypoint targetPoint = new RouteWaypoint("Searched location", new GeoPoint(lat, lon));
            routeProvider.CalculateRoutesFromMajorRoads(targetPoint);
        }

        #region #RouteCalculated
        private void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            RouteCalculationResult result = e.CalculationResult;
            if((result.RouteResults == null) ||
                (result.ResultCode == RequestResultCode.BadRequest)) {
                rtbResults.Text = "The Bing Route service does not work for this location.";
                return;
            }

            StringBuilder resultList = new StringBuilder("");

            if(result.IntermediatePoints != null) {
                resultList.Append(String.Format("_________________________\n"));

                for(int i = 0; i < e.CalculationResult.IntermediatePoints.Count; i++)
                    resultList.Append(
                        String.Format("Starting point {0}: {1} ({2})\n",
                        i + 1,
                        e.CalculationResult.IntermediatePoints[i].Description,
                        e.CalculationResult.IntermediatePoints[i].Location)
                    );
            }

            if((result.RouteResults != null) & (result.ResultCode == RequestResultCode.Success)) {

                for(int rnum = 0; rnum < e.CalculationResult.RouteResults.Count; rnum++) {
                    resultList.Append(String.Format("_________________________\n"));
                    resultList.Append(String.Format("Path {0}:\n", rnum + 1));
                    resultList.Append(String.Format(
                        "Distance: {0}\n",
                        e.CalculationResult.RouteResults[rnum].Distance
                    ));
                    resultList.Append(String.Format(
                        "Time: {0}\n",
                        e.CalculationResult.RouteResults[0].Time
                    ));

                    if(e.CalculationResult.RouteResults[rnum].Legs != null) {
                        int legNum = 1;
                        foreach(BingRouteLeg leg in e.CalculationResult.RouteResults[rnum].Legs) {
                            resultList.Append(String.Format("\tLeg {0}:\n", legNum++));
                            resultList.Append(String.Format("\tDistance: {0}\n", leg.Distance));
                            resultList.Append(String.Format("\tTime: {0}\n", leg.Time));
                            if(leg.Itinerary != null) {
                                foreach(BingItineraryItem itineraryItem in leg.Itinerary) {
                                    resultList.Append(String.Format(itineraryItem.Maneuver + "\n"));
                                    resultList.Append(String.Format(
                                        "\t\tLocation: {0}\n",
                                        itineraryItem.Location
                                    ));
                                }
                            }
                        }
                    }
                }
            }
            rtbResults.Text = resultList.ToString();
        }
        #endregion #RouteCalculated
    }
}