// See https://aka.ms/new-console-template for more information
using Generate.Models;
using Generate.Services;
 

ITemplateService templateService = new TemplateService();

//Examples of calling with different arguments
BasicInfo basicInfo = new BasicInfo("Virág");
var result0 = templateService.GetTemplate(basicInfo);
Console.WriteLine(result0);
Console.WriteLine();

MeetingInfo info = new MeetingInfo("Gyuri", new Address("Budapest", "Föveny u. 4-6-5. em, 1138"));
var result1 = templateService.GetTemplate(info);
Console.WriteLine(result1);
Console.WriteLine();

Personalnfo pInfo = new Personalnfo("Béla", "Gyuri", "gyuri@email.com", "+3630212131");
var result2 = templateService.GetTemplate(pInfo);
Console.WriteLine(result2);
Console.WriteLine();