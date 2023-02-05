using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<RedisTest.Administration.RoleRow>;
using MyRow = RedisTest.Administration.RoleRow;


namespace RedisTest.Administration
{
    public interface IRoleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class RoleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRoleListHandler
    {
        public RoleListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}