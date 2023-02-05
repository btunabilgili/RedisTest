using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = RedisTest.Test.TestTableRow;

namespace RedisTest.Test
{
    public interface ITestTableDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TestTableDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITestTableDeleteHandler
    {
        public TestTableDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}