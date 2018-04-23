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

        double lat = 40;
        double lon = -120;

        InformationLayer RouteLayer { 
            get {
                return (InformationLayer)mapControl1.Layers["RouteLayer"];
            }
        }
        BingRouteDataProvider RouteProvider { 
            get {
                return (BingRouteDataProvider)RouteLayer.DataProvider;
            }
        }
        
        public Form1() {
            InitializeComponent();

            tbLatitude.Text = lat.ToString();
            tbLongitude.Text = lon.ToString();

            #region #InitBingRouteOptions
            lbTravelMode.DataSource = Enum.GetValues(typeof(BingTravelMode));
            lbRouteOptimization.DataSource = Enum.GetValues(typeof(BingRouteOptimization));
            #endregion #InitBingRouteOptions

            RouteLayer.DataRequestCompleted += RouteLayer_DataRequestCompleted;
            RouteProvider.LayerItemsGenerating += RouteProvider_LayerItemsGenerating;
            RouteProvider.RouteCalculated += RouteProvider_RouteCalculated;

        }

        #region #LayerItemsGenerating
        void RouteProvider_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            foreach (MapItem item in e.Items) {
                MapPolyline polyline = item as MapPolyline;
                if (polyline != null) {
                    polyline.Stroke = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
                    polyline.StrokeWidth = 4;
                }
            }
        }
        #endregion #LayerItemsGenerating

        #region #DataRequestCompleted
        void RouteLayer_DataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl1.ZoomToFitLayerItems(0.4);
        }
        #endregion #DataRequestCompleted

        #region #BingRouteOptionsChanged
        private void lbTravelMode_SelectedIndexChanged(object sender, EventArgs e) {
            RouteProvider.RouteOptions.Mode = (BingTravelMode)lbTravelMode.SelectedValue;
        }

        private void lbRouteOptimization_SelectedIndexChanged(object sender, EventArgs e) {
            RouteProvider.RouteOptions.RouteOptimization = 
                (BingRouteOptimization)lbRouteOptimization.SelectedValue;
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

        private void tbLatitude_Validating(object sender, CancelEventArgs e) {
            if (!Double.TryParse(tbLatitude.Text, out lat) ||
                (lat > maxLat) || (lat < minLat)) {
                e.Cancel = true;
                ShowErrorMessage("Latitude", minLat, maxLat);
            }
        }

        private void tbLongitude_Validating(object sender, CancelEventArgs e) {
            if (!Double.TryParse(tbLongitude.Text, out lon) ||
                (lon > maxLon) || (lon < minLon)) {
                e.Cancel = true;
                ShowErrorMessage("Longitude", minLon, maxLon);
            }
        }

        private void bCalculateRoutes_Click(object sender, EventArgs e) {
            RouteProvider.CalculateRoutesFromMajorRoads(
                new RouteWaypoint(
                    "Searched location", 
                    new GeoPoint(lat, lon)
                )
            );
        }

        #region #RouteCalculated
        private void RouteProvider_RouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            RouteCalculationResult result = e.CalculationResult;
            if ((result.RouteResults == null) || 
                (result.ResultCode == RequestResultCode.BadRequest)) {
                    rtbResults.Text = "The Bing Route service does not work for this location.";
                    return;
            }

            StringBuilder resultList = new StringBuilder("");

            if (result.IntermediatePoints != null) {
                resultList.Append(String.Format("_________________________\n"));

                for (int i = 0; i < e.CalculationResult.IntermediatePoints.Count; i++)
                    resultList.Append(
                        String.Format("Starting point {0}: {1} ({2})\n", 
                        i + 1,
                        e.CalculationResult.IntermediatePoints[i].Description, 
                        e.CalculationResult.IntermediatePoints[i].Location)
                    );
            }

            if ((result.RouteResults != null) & (result.ResultCode == RequestResultCode.Success)) {

                for (int rnum = 0; rnum < e.CalculationResult.RouteResults.Count; rnum++) {
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

                    if (e.CalculationResult.RouteResults[rnum].Legs != null) {
                        int legNum = 1;
                        foreach (BingRouteLeg leg in e.CalculationResult.RouteResults[rnum].Legs) {
                            resultList.Append(String.Format("\tLeg {0}:\n", legNum++));
                            resultList.Append(String.Format("\tDistance: {0}\n", leg.Distance));
                            resultList.Append(String.Format("\tTime: {0}\n", leg.Time));
                            if (leg.Itinerary != null) {
                                foreach (BingItineraryItem itineraryItem in leg.Itinerary) {
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