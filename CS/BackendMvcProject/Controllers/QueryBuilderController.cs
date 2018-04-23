using System.Web.Mvc;
using DevExpress.Web.Mvc.Controllers;


namespace BackendMvcProject.Controllers {
    // This controller processes internal requests from the Query Builder that is a part of the Report Designer.
    public class QueryBuilderController : QueryBuilderApiController {
        public override ActionResult Invoke() {
            var result = base.Invoke();
            // Allow cross-domain requests.
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            return result;
        }
    }
}