using System.Linq;
using dashboard.Shared.Constants.Localization;
using dashboard.Shared.Settings;

namespace dashboard.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}