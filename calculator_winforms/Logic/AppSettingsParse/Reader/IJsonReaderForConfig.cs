using OTSCSERVER.Tools.AppSettingsParse.Templaetes;

namespace OTSCSERVER.Tools.AppSettingsParse.Reader
{
    internal interface IJsonReaderForConfig
    {
        T Read<T>(string filePath) where T : ITemplates;
    }
}
