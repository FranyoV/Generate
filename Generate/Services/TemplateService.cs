using Generate.Models;
using System.Text.Json;

namespace Generate.Services
{
    public class TemplateService : ITemplateService
    {
        private static string FileName   
            => Path.Combine(
                 Directory.GetParent(
                     Directory.GetParent(
                         Directory.GetParent(
                             Environment.CurrentDirectory)!.ToString())!.ToString())!.ToString(), "Templates/Templates.json");


        private List<Template> ReadTemplates()
        {
            JsonSerializerOptions? options = new JsonSerializerOptions()
            {
                NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString
                | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString
            };

            List<Template>? templates = new();

            try
            {
                var temp = File.ReadAllText(FileName);
                templates = JsonSerializer.Deserialize<List<Template>>(temp, options);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }
            return templates;
        }


        private Template FindTemplate(List<Template> templates, int id)
        {
            var selectedTemplate = templates.FirstOrDefault(x => x.Id == id)!;
            return selectedTemplate;
        }
      

        public string GetTemplate(BasicInfo info)
        {
            var templates = ReadTemplates();

            var neededTemplate = FindTemplate(templates, info.TemplateId);

            if (neededTemplate != null  
                && info != null
                && info.Recipient != null)
            {
                var body = neededTemplate.Body.Replace("{Recipient}", info.Recipient);
                return body;
            }
            else
            {
                return "Please try again with specified information.";
            }                    
        }


        public string GetTemplate(MeetingInfo info)
        {
            var templates = ReadTemplates();

            var neededTemplate = FindTemplate(templates, info.TemplateId);

            if (neededTemplate != null 
                && info != null
                && info.Recipient != null 
                && info.Address != null
                && info.Address.City != null 
                && info.Address.Street != null)
            {
                var body = neededTemplate.Body
                    .Replace("{Recipient}", info.Recipient)
                    .Replace("{Address.City}", info.Address.City)
                    .Replace("{Address.Street}", info.Address.Street);

                return body;
            }
            else
            {
                return "Please try again with specified information.";
            }
        }


        public string GetTemplate(Personalnfo info)
        {
            var templates = ReadTemplates();

            var neededTemplate = FindTemplate(templates, info.TemplateId);

            if (neededTemplate != null
                && info != null
                && info.Recipient != null
                && info.Name != null
                && info.Email != null
                && info.PhoneNumber != null)
            {
                var body = neededTemplate.Body
                                .Replace("{Recipient}", info.Recipient)
                                .Replace("{Name}", info.Name)
                                .Replace("{Email}", info.Email)
                                .Replace("{PhoneNumber}", info.PhoneNumber);

                return body;
            }
            else
            {
                return "Please try again with specified information.";
            }
        }
    }
}
