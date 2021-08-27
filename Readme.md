<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128596863/17.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T505059)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [app.config.js](./CS/ClientSideDevExtremeProject/app.config.js) (VB: [app.config.js](./VB/ClientSideDevExtremeProject/app.config.js))
* [bower.json](./CS/ClientSideDevExtremeProject/bower.json) (VB: [bower.json](./VB/ClientSideDevExtremeProject/bower.json))
* [index.html](./CS/ClientSideDevExtremeProject/index.html) (VB: [index.html](./VB/ClientSideDevExtremeProject/index.html))
* [reportDesigner.html](./CS/ClientSideDevExtremeProject/views/reportDesigner.html) (VB: [reportDesigner.html](./VB/ClientSideDevExtremeProject/views/reportDesigner.html))
* **[reportDesigner.js](./CS/ClientSideDevExtremeProject/views/reportDesigner.js) (VB: [reportDesigner.js](./VB/ClientSideDevExtremeProject/views/reportDesigner.js))**
* [QueryBuilderController.cs](./CS/ServerSide/Controllers/QueryBuilderController.cs) (VB: [QueryBuilderController.vb](./VB/ServerSide/Controllers/QueryBuilderController.vb))
* [ReportDesignerController.cs](./CS/ServerSide/Controllers/ReportDesignerController.cs) (VB: [ReportDesignerController.vb](./VB/ServerSide/Controllers/ReportDesignerController.vb))
* [WebDocumentViewerController.cs](./CS/ServerSide/Controllers/WebDocumentViewerController.cs) (VB: [WebDocumentViewerController.vb](./VB/ServerSide/Controllers/WebDocumentViewerController.vb))
* [Global.asax.cs](./CS/ServerSide/Global.asax.cs) (VB: [Global.asax.vb](./VB/ServerSide/Global.asax.vb))
* [MyReportStorage.cs](./CS/ServerSide/MyReportStorage.cs) (VB: [MyReportStorage.vb](./VB/ServerSide/MyReportStorage.vb))
<!-- default file list end -->
# How to use the Web Report Designer in a DevExtreme application

<strong>Important:</strong>&nbsp;<br>Starting with v18.1, the DevExtreme hybrid mobile-related tools and the demonstrated integration approach are deprecated. See <a href="https://community.devexpress.com/blogs/aspnet/archive/2018/02/26/devextreme-hybrid-mobile-tools-deprecation-in-v18-1.aspx">this blog post</a> for more information.<br>
<p>Refer to the following online example for an alternative integration approach: <a href="https://github.com/DevExpress-Examples/how-to-use-the-web-report-designer-in-javascript-t561230">How to use the Web Report Designer in JavaScript</a>.</p>
<br>

This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Web Report Designer</a> into a <a href="https://js.devexpress.com/">DevExtreme</a> application.<br><br>The example consists of two projects: a server (backend) project in ASP.NET MVC implementation and a client (frontend) DevExtreme application, which includes all necessary styles, scripts, and HTML-templates.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119332/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Report-Designer-Integration-into-a-DevExtreme-application">Report Designer Integration into a DevExtreme application</a>.<br><br>


<h3>Description</h3>

To download all necessary client resources for this example, open the console,&nbsp;navigate to the client-side folder and run the following command:<br><em>bower install</em><br><br><strong>Note:</strong>&nbsp;<br>Some modules may not be downloaded (or downloaded incorrectly) on a machine that does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, all client resources are downloaded and installed in advance.<br><br>
<p>The "<strong>Restore Bower packages</strong>" operation in Visual Studio may be executed incorrectly if the downloaded version is different from the last one.</p>
<p>This is a known issue on part of Visual Studio (<a href="https://github.com/aspnet/Tooling/issues/575">https://github.com/aspnet/Tooling/issues/575</a>) and we recommend that you use the solution provided in the following article:&nbsp;<a href="http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014">http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014</a>.</p>

<br/>


