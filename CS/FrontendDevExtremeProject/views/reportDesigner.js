FrontendDevExtremeProject.reportDesigner = function (params, viewInfo) {
    "use strict";

    var id = params.id,
        designerModel = ko.observable(null),
        initializationData = ko.observable(null),
        backendPrefix = 'http://localhost:1848/'; // URI of your backend project.

    // This example uses the following localization script: 'bower_components/xtrareportsjs/js/localization/report-designer.en.js'.
    // Uncomment the following lines if you want to get localization data from the server (from the DevExpress Localization Service). 
    //$.getJSON(backendPrefix + '/ReportDesigner/GetLocalization') // 
    //    .fail(function (a, b, c) {
    //        alert(b + ": " + c.message);
    //    })
    //    .done(function(localization) {
    //        localization && DevExpress.JS.Localization.addCultureInfo(localization);
            $.post(backendPrefix + '/ReportDesigner/GetReportDesignerModel', { reportUrl: "" }) // Get the Report Designer model. 
                .fail(function(a, b, c) {
                    alert(b + ": " + c.message);
                })
                .done(function (result) {
                    // Set initialization data provided by the GetReportDesignerModel action.
                    initializationData(result); 
                    // Specify handler URIs.
                    DevExpress.Designer.Report.HandlerUri = backendPrefix + DevExpress.Designer.Report.HandlerUri;
                    DevExpress.Report.Preview.HandlerUri = backendPrefix + DevExpress.Report.Preview.HandlerUri;
                    DevExpress.Designer.QueryBuilder.HandlerUri = backendPrefix + DevExpress.Designer.QueryBuilder.HandlerUri;
                });
    //});

    return {
        id: id,
        callbacks: { /* */ },  // An input parameter for the dxReportDesigner binding. 
                               // Use this object to customize specific Report Designer callbacks.
        designerModel: designerModel, //An output parameter for the dxReportDesigner binding. 
                                      // This object provides client API to customize the Report Designer.
        initializationData: initializationData // An input parameter for the dxReportDesigner binding. 
                                               // Initialization data is obtained from the server (using the GetReportDesignerModel action).
    };
};