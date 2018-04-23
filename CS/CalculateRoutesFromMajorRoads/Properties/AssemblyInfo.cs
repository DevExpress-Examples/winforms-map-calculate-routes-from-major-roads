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

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CalculateRoutesFromMajorRoads")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("CalculateRoutesFromMajorRoads")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("3db906fb-3d3e-46f2-9f79-bf7824e2b22c")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
