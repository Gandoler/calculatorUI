using OTSC_ui.Tools.AppSettingJsonPhars.Reader;
using OTSC_ui.Tools.AppSettingJsonPhars.Temaplates;
using Serilog;

namespace OTSC_ui.Tools.AppSettingJsonPhars.ConnectionStringManager
{
    internal static class ConnectionStringManager
    {
        static RootConfig rootConfig = new();

        static ConnectionStringManager()
        {
            GoDeserialiseObject();
        }
        private static void GoDeserialiseObject()
        {
          
            JsonReaderForConfig jsonReader = new();
            try
            {
                rootConfig = jsonReader.Read<RootConfig>(Properties.Settings1.Default.AppsettingsPath);
                Log.Information($"ConnectionStringManager: settings:{rootConfig}");
            }
            catch (Exception ex)
            {
                Log.Error($"In ConnectionStringManager {ex.Message}");
            }
            
        }

        public static string? GetConnectionString()
        { 
            if (rootConfig.ServerSettings != null)
            {
                return rootConfig.ServerSettings.GetConnectionString();
            }
            return null;
        }
        public static EmailSettings GetEmailSettings()
        {
            return rootConfig.EmailSettings;
        }
       
    }
}
