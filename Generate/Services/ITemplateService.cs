using Generate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate.Services
{
    public interface ITemplateService
    {
        string GetTemplate(BasicInfo info);
        string GetTemplate(Personalnfo info);
        string GetTemplate(MeetingInfo info);
    }
}
