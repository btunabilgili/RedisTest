using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<RedisTest.Administration.RoleRow>;
using MyRow = RedisTest.Administration.RoleRow;


namespace RedisTest.Administration
{
    public interface IRoleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class RoleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRoleRetrieveHandler
    {
        public RoleRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}