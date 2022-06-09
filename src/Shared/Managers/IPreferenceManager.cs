using dashboard.Shared.Settings;
using System.Threading.Tasks;
using dashboard.Shared.Wrapper;

namespace dashboard.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}