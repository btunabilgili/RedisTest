using Serenity.Services;
using MyRequest = RedisTest.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<RedisTest.Administration.UserRow>;
using MyRow = RedisTest.Administration.UserRow;

namespace RedisTest.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}