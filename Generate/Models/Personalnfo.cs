
namespace Generate.Models
{
    public class Personalnfo : BasicInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public new int TemplateId = 2;
        public Personalnfo(string recipient, string name, string email, string phoneNumber) : base(recipient)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
