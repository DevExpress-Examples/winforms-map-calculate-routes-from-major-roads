// Developer Express Code Central Example:
// How to calculate routes from major roads using the Bing Map Route web service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button. All parameters are passed to the CalculateMajorRouteRequest
// method, and you can see the results in the rich text box element and calculated
// routes on a map. The requested results contain the total distance of a route,
// itinerary item (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuvers associated with the itinerary item
// (BingItineraryItem.Maneuver
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

// Developer Express Code Central Example:
// How to calculate routes from major roads using the Bing Map Route web service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button. All parameters are passed to the CalculateMajorRouteRequest
// method, and you can see the results in the rich text box element and calculated
// routes on a map. The requested results contain the total distance of a route,
// itinerary item (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuvers associated with the itinerary item
// (BingItineraryItem.Maneuver
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

// Developer Express Code Central Example:
// How to get routes to the destination point using the Bing Map Route data service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button, which handles the calculateRoutes_Click event. All parameters are
// passed to the CalculateMajorRouteRequest method, and you can see the results in
// the rich text box element and calculated routes on a map. The requested results
// contain the total distance of a route, route leg, itinerary item
// (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuver instructions associated with the itinerary item
// (BingItineraryItem.ManeuverInstruction
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_ManeuverInstructiontopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculateRoutesFromMajorRoads.Properties {


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if ((resourceMan == null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CalculateRoutesFromMajorRoads.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
    }
}
