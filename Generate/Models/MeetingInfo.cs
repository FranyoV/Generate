
namespace Generate.Models
{
    public class MeetingInfo : BasicInfo
    {
        public Address Address { get; set; }

        public new int TemplateId = 1;
        public MeetingInfo(string recipient, Address address) : base(recipient)
        {
            this.Address = address;
        } 
    }
}
