using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TDD.NameInverter
{
    public class NameInverter
    {
        public string InvertName(string name)
        {
            if (name == null || name.Length <= 0)
                return string.Empty;
            else
                return FormatName(RemoveHonorifics(SplitNames(name)));
        }

        private string FormatName(List<string> names)
        {
            if (names.Count == 1)
                return names[0];
            else
                return FormatMultiElementName(names);
        }

        private string FormatMultiElementName(List<string> names)
        {
            string postNominal = GetPostNominals(names);
            string firstName = names[0];
            string lastName = names[1];
            return String.Format("{0}, {1} {2}", lastName, firstName, postNominal).Trim();
        }

        private string GetPostNominals(List<string> names)
        {
            string postNominal = String.Empty;
            if (names.Count > 2)
            {
                List<string> postNominals = names.GetRange(2, names.Count() - 2);
                foreach (var pn in postNominals)
                    postNominal += pn + " ";
            }
            return postNominal;
        }

        private List<string> RemoveHonorifics(List<string> names)
        {
            if (names.Count > 1 && IsHonorific(names.First()))
                names.RemoveAt(0);
            return names;
        }

        private List<string> SplitNames(string name)
        {
            return name
                    .Trim()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
        }

        private bool IsHonorific(string name)
        {
            return Regex.IsMatch(name, "Mr\\.|Mrs\\.");
        }
    }
}
