using System.Collections.Generic;
using Nancy.ViewEngines.Razor;

namespace Web
{
    
    public class RazorConfig : IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            yield return "Web";
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            yield return "Web.Models";
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }    
}