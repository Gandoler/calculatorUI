
using Newtonsoft.Json;

namespace OTSCSERVER.Tools.AppSettingsParse.Templaetes
{
    public class RootConfig : ITemplates
    {
        [JsonProperty("serverSetings")]
        public ServerSettings ServerSettings { get; set; }
        public RootConfig(ServerSettings serverSettings)
        {
            ServerSettings = serverSettings;
        }

        

        public string GetConnectionString()
        {
            return ServerSettings.ToString();
        }

        public override string ToString()
        {
            return ServerSettings.ToString() ;
        }

    }
}
