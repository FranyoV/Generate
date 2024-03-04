
namespace Generate.Models
{
    public class BasicInfo
    {
        public string Recipient { get; set; }

        public int TemplateId = 0;

        public BasicInfo(string recipient) {
            this.Recipient = recipient;           
        }   
    }
}
