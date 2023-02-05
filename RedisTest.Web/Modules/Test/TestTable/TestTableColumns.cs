using Serenity.ComponentModel;
using System.ComponentModel;

namespace RedisTest.Test.Columns
{
    [ColumnsScript("Test.TestTable")]
    [BasedOnRow(typeof(TestTableRow), CheckNames = true)]
    public class TestTableColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Test { get; set; }
        public int Test2 { get; set; }
    }
}