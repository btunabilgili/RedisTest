using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace RedisTest.Test
{
    [ConnectionKey("Default"), Module("Test"), TableName("[dbo].[TestTable]")]
    [DisplayName("Test Table"), InstanceName("Test Table")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class TestTableRow : Row<TestTableRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Test"), Column("test"), Size(50), QuickSearch, NameProperty]
        public string Test
        {
            get => fields.Test[this];
            set => fields.Test[this] = value;
        }

        [DisplayName("Test2"), Column("test2")]
        public int? Test2
        {
            get => fields.Test2[this];
            set => fields.Test2[this] = value;
        }

        public TestTableRow()
            : base()
        {
        }

        public TestTableRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Test;
            public Int32Field Test2;
        }
    }
}