using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace RedisTest.Test.Pages 
{

    [PageAuthorize(typeof(TestTableRow))]
    public class TestTableController : Controller
    {
        [Route("Test/TestTable")]
        public ActionResult Index()
        {
            return this.GridPage("@/Test/TestTable/TestTablePage",
                TestTableRow.Fields.PageTitle());
        }
    }
}