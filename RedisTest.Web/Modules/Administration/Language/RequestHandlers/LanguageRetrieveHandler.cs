using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<RedisTest.Administration.LanguageRow>;
using MyRow = RedisTest.Administration.LanguageRow;


namespace RedisTest.Administration
{
    public interface ILanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageRetrieveHandler
    {
        public LanguageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}