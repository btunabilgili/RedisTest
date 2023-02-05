using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<RedisTest.Administration.LanguageRow>;
using MyRow = RedisTest.Administration.LanguageRow;


namespace RedisTest.Administration
{
    public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
    {
        public LanguageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}