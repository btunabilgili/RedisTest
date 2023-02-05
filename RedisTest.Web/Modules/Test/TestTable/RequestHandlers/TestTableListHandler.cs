using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<RedisTest.Test.TestTableRow>;
using MyRow = RedisTest.Test.TestTableRow;

namespace RedisTest.Test
{
    public interface ITestTableListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TestTableListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITestTableListHandler
    {
        public TestTableListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}