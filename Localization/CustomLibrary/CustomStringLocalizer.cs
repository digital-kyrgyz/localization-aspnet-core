using Microsoft.Extensions.Localization;
using System.Collections.Generic;
using System.Globalization;

namespace Localization.CustomLibrary
{
    public class CustomStringLocalizer : IStringLocalizer
    {
        private Dictionary<string, Dictionary<string, string>> resources;
        private const string HEADER = "Header";
        private const string MESSAGE = "Message";

        public CustomStringLocalizer()
        {
            Dictionary<string, string> enDict = new Dictionary<string, string>
            {
                {HEADER, "Welcome" },
                {MESSAGE, "Hello world" }
            };
            Dictionary<string, string> ruDict = new Dictionary<string, string>
            {
                {HEADER, "Добро пожаловать" },
                {MESSAGE, "Привет Мир!" }
            };
            Dictionary<string, string> deDict = new Dictionary<string, string>
            {
                {HEADER, "Willkommen" },
                {MESSAGE, "Hallo Welt!" }
            };
            Dictionary<string, string> kgDict = new Dictionary<string, string>
            {
                {HEADER, "Кош келиниздер" },
                {MESSAGE, "Салам дунйо" }
            };
            resources = new Dictionary<string, Dictionary<string, string>>
            {
                {"en", enDict},
                {"ru", ruDict},
                {"de", deDict},
                {"kg", kgDict},
            };
        }

        public LocalizedString this[string name]
        {
            get
            {
                var currentCulture = CultureInfo.CurrentUICulture;
                string val = "";
                if (resources.ContainsKey(currentCulture.Name))
                {
                    if (resources[currentCulture.Name].ContainsKey(name))
                    {
                        val = resources[currentCulture.Name][name];
                    }
                }
                return new LocalizedString(name, val);
            }
        }

        public LocalizedString this[string name, params object[] arguments] => throw new System.NotImplementedException();

        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            throw new System.NotImplementedException();
        }

        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return this;
        }
    }
}