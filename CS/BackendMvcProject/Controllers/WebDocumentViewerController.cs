using System.Web.Mvc;
using DevExpress.Web.Mvc.Controllers;

namespace BackendMvcProject.Controllers {
    // This controller processes internal requests from the Web Document Viewer that is a part of the Report Designer.
    public class WebDocumentViewerController : WebDocumentViewerApiController {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}