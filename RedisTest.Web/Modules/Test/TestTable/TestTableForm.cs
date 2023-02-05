using Serenity.ComponentModel;
using Serenity.Web;

namespace RedisTest.Test.Forms
{
    [FormScript("Test.TestTable")]
    [BasedOnRow(typeof(TestTableRow), CheckNames = true)]
    public class TestTableForm
    {
        public string Test { get; set; }
        public int Test2 { get; set; }
    }
}