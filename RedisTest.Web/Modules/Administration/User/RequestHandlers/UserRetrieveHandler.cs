using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<RedisTest.Administration.UserRow>;
using MyRow = RedisTest.Administration.UserRow;


namespace RedisTest.Administration
{
    public interface IUserRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }
    public class UserRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserRetrieveHandler
    {
        public UserRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}