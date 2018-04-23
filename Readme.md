# How to use the Web Report Designer in a DevExtreme application


This example illustrates how to integrate the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17103">End-User Web Report Designer</a> into a <a href="https://js.devexpress.com/">DevExtreme</a> application.<br><br>The example consists of two projects: a server (backend) project in ASP.NET MVC implementation and a client (frontend) DevExtreme application, which includes all necessary styles, scripts, and HTML-templates.<br><br>For a step-by-step tutorial, refer to the following document: <a href="https://documentation.devexpress.com/XtraReports/119332/Creating-End-User-Reporting-Applications/Web-Reporting/Using-Reporting-Controls-in-JS/Report-Designer-Integration-into-a-DevExtreme-application">Report Designer Integration into a DevExtreme application</a>.<br><br><strong>See also:<br></strong><a href="https://www.devexpress.com/Support/Center/Example/Details/T370591">How to use the HTML5 Document Viewer within a DevExtreme application</a><br><br>


<h3>Description</h3>

In this example, all necessary client resources are downloaded and installed in advance using Bower (<a href="https://bower.io/docs/api/">https://bower.io/docs/api/</a>).<br>To download a required Web Report Designer version (e.g., <strong>17.1.3</strong>), specify this version in bower.json or install it using the following command:<br><em>bower install xtrareportsjs#17.1.3&nbsp;&nbsp;</em><br><br><strong>Note:</strong> <br>Some modules may not be downloaded (or downloaded incorrectly) on a machine that does not have Git (<a href="https://git-scm.com/">https://git-scm.com/</a>) installed on it. In this example, all client resources are downloaded and installed in advance.<br><br>
<p>The "<strong>Restore Bower packages</strong>" operation in Visual Studio may be executed incorrectly if the downloaded version is different from the last one.</p>
<p>This is a known issue on part of Visual Studio (<a href="https://github.com/aspnet/Tooling/issues/575">https://github.com/aspnet/Tooling/issues/575</a>) and we recommend that you use the solution provided in the following article: <a href="http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014">http://stackoverflow.com/questions/37584520/bootstrap-3-3-6-jquery-2-2-4-version-exception/38460014#38460014</a>.</p>

<br/>


