using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<RedisTest.Test.TestTableRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = RedisTest.Test.TestTableRow;

namespace RedisTest.Test
{
    public interface ITestTableSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TestTableSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITestTableSaveHandler
    {
        public TestTableSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}