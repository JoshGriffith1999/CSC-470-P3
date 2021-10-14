using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3
{
    class FakePreferenceRepository : IPreferenceRepository
    {
        public const string PREFERENCE_PROJECY_ID = "PREFERENCE_PROJECY_ID";
        public const string PREFERENCE_PROJECY_NAME = "PREFERENCE_PROJECY_NAME";
        private const string NO_ERROR = "NO Erros";
        private static Dictionary<string, Dictionary<string, string>> Preferences = new Dictionary<string, Dictionary<string, string>>();
        /*****************************************/
        public string GetPreference(string UserName, string PreferenceName) {
            Dictionary<string, string> NameValuepair = new Dictionary<string, string>();
            string value = "";
            if(Preferences.TryGetValue(UserName, out NameValuepair))
            {
                NameValuepair.TryGetValue(PreferenceName, out value);
            }

            return value;
        }
        public string SetPreference(string UserName, string PreferenceName, string Value)
        {
            Dictionary<string, string> NameValuepair = new Dictionary<string, string>();
            NameValuepair.Add(UserName, PreferenceName);
            Preferences.Add(Value, NameValuepair);

            return Value;
        }
    }
}
