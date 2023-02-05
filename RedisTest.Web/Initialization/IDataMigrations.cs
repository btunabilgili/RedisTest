namespace RedisTest
{
    public interface IDataMigrations
    {
        bool SkippedMigrations { get; }

        void Initialize();
    }
}