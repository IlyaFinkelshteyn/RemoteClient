using System;
using System.Collections.Generic;
using System.Text;

namespace WcfRestClient.Helpers
{
    public static class WcfUri
    {
        public static string GetStringFromTemplate(string template, Dictionary<string, object> dictionary)
        {
            if (string.IsNullOrEmpty(template))
                return null;
            if (template[0] == '/')
            {
                template = template.Substring(1);
            }
            if (dictionary.Count == 0)
                return template;
            var sb = new StringBuilder(template);
            foreach (var pair in dictionary)
            {
                string stringifiedValue = Convert.ToString(pair.Value, LibraryCulture.CultureInfo);
                sb.Replace("{" + pair.Key + "}", stringifiedValue);
            }
            return sb.ToString();
        }

        public static Uri GetUriFromTemlate(string template, Dictionary<string, object> dictionary)
        {
            var uriString = GetStringFromTemplate(template, dictionary);
            if (uriString == null)
            {
                return null;
            }
            return new Uri(uriString, UriKind.Relative);
        }
    }
}