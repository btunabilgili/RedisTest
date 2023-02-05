using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<RedisTest.Test.TestTableRow>;
using MyRow = RedisTest.Test.TestTableRow;

namespace RedisTest.Test
{
    public interface ITestTableRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TestTableRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITestTableRetrieveHandler
    {
        public TestTableRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}