namespace exercise.wwwapi.Configuration
{
    public class Config : IConfig
    {
        IConfiguration _configuration;
        public Config()
        {
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        }
        public string GetValue(string key)
        {
            return _configuration.GetValue<string>(key)!;
        }
    }
}
