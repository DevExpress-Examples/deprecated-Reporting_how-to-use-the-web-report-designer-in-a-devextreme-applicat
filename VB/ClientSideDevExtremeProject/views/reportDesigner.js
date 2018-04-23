ClientSideDevExtremeProject.reportDesigner = function (params, viewInfo) {
    "use strict";

    const host = 'http://localhost:54111/',
    reportUrl = "Products",
    designerOptions = {
        reportUrl,
        requestOptions: {
            host,
            getDesignerModelAction: "/ReportDesigner/GetReportDesignerModel"
        }
    }

    return { designerOptions: designerOptions };
};