using System.Globalization;
using System.Resources;
using WorkFloo.Application.DTOs;
using WorkFloo.Application.Interfaces;
using WorkFloo.Infrastructure.Resources.ProjectResources;

namespace WorkFloo.Infrastructure.Resources.Services
{
    public class Translator : ITranslator
    {

        private readonly ResourceManager resourceMessages;
        private readonly ResourceManager propertyName;

        public string this[string name] => propertyName.GetString(name, CultureInfo.CurrentCulture) ?? name;

        public Translator()
        {
            resourceMessages = new ResourceManager(typeof(ResourceMessages).FullName, typeof(ResourceMessages).Assembly);
            propertyName = new ResourceManager(typeof(ResourceGeneral).FullName, typeof(ResourceGeneral).Assembly);
        }
        public string GetString(string name)
        {
            return resourceMessages.GetString(name, CultureInfo.CurrentCulture) ?? name;
        }

        public string GetString(TranslatorMessageDto input)
        {
            var value = resourceMessages.GetString(input.Text, CultureInfo.CurrentCulture) ?? input.Text.Replace("_", " ");
            return string.Format(value, input.Args);
        }
    }
}
