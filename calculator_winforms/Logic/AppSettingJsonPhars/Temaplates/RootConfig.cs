using Newtonsoft.Json;

namespace OTSC_ui.Tools.AppSettingJsonPhars.Temaplates
{
    internal class RootConfig : ITemplates
    {
        [JsonProperty("serverSetings")] // Укажите правильное имя из JSON
        public ServerSettings ServerSettings { get; set; } = new ServerSettings();

        [JsonProperty("emailSetings")]
        public EmailSettings EmailSettings { get; set; } = new EmailSettings();


        public string GetConnectionString()
        {
            return EmailSettings?.ToString() + ServerSettings?.ToString();
        }
        public override string ToString()
        {
            return EmailSettings?.ToString() + ServerSettings?.ToString();
        }

    }
}
