<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596863/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T505059)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [QueryBuilderController.cs](./CS/BackendMvcProject/Controllers/QueryBuilderController.cs) (VB: [QueryBuilderController.vb](./VB/BackendMvcProject/Controllers/QueryBuilderController.vb))
* [ReportDesignerController.cs](./CS/BackendMvcProject/Controllers/ReportDesignerController.cs) (VB: [ReportDesignerController.vb](./VB/BackendMvcProject/Controllers/ReportDesignerController.vb))
* [WebDocumentViewerController.cs](./CS/BackendMvcProject/Controllers/WebDocumentViewerController.cs) (VB: [WebDocumentViewerController.vb](./VB/BackendMvcProject/Controllers/WebDocumentViewerController.vb))
* [app.config.js](./CS/FrontendDevExtremeProject/app.config.js) (VB: [app.config.js](./VB/FrontendDevExtremeProject/app.config.js))
* [bower.json](./CS/FrontendDevExtremeProject/bower.json) (VB: [bower.json](./VB/FrontendDevExtremeProject/bower.json))
* [index.html](./CS/FrontendDevExtremeProject/index.html) (VB: [index.html](./VB/FrontendDevExtremeProject/index.html))
* [reportDesigner.html](./CS/FrontendDevExtremeProject/views/reportDesigner.html) (VB: [reportDesigner.html](./VB/FrontendDevExtremeProject/views/reportDesigner.html))
* **[reportDesigner.js](./CS/FrontendDevExtremeProject/views/reportDesigner.js) (VB: [reportDesigner.js](./VB/FrontendDevExtremeProject/views/reportDesigner.js))**
<!-- default file list end -->
# How to use the Web Report Designer in a DevExtreme application


This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Web Report Designer</a> into a <a href="https://js.devexpress.com/">DevExtreme</a> application.<br><br>The example consists of two projects: a server (backend) project in ASP.NET MVC implementation and a client (frontend) DevExtreme application, which includes all necessary styles, scripts, and HTML-templates.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119332/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Report-Designer-Integration-into-a-DevExtreme-application">Report Designer Integration into a DevExtreme application</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/Example/Details/T370591">How to use the HTML5 Document Viewer within a DevExtreme application</a><br><br>


<h3>Description</h3>

In this example, all necessary client resources are downloaded and installed in advance using Bower (<a href="https://bower.io/docs/api/">https://bower.io/docs/api/</a>).<br>To download a required Web Report Designer version (e.g., <strong>17.1.3</strong>), specify this version in bower.json or install it using the following command:<br><em>bower install xtrareportsjs#17.1.3&nbsp;&nbsp;</em><br><br><strong>Note:</strong> <br>Some modules may not be downloaded (or downloaded incorrectly) on a machine that does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, all client resources are downloaded and installed in advance.<br><br>
<p>The "<strong>Restore Bower packages</strong>" operation in Visual Studio may be executed incorrectly if the downloaded version is different from the last one.</p>
<p>This is a known issue on part of Visual Studio (<a href="https://github.com/aspnet/Tooling/issues/575">https://github.com/aspnet/Tooling/issues/575</a>) and we recommend that you use the solution provided in the following article: <a href="http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014">http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014</a>.</p>

<br/>


