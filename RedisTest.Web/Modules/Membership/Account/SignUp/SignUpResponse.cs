using Serenity.Services;

namespace RedisTest.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}