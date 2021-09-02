using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace AdaptItAcademy.DataAccess.Models
{
    public class ConsoleEmailSender: IEmailSender
    {
        public Task SendEmailAsync(string emailAddress, string subject, string htmlMessage)
        {
            WriteLine("----New Mail----");
            WriteLine($"To: {emailAddress}");
            WriteLine($"Subject: {subject}");
            WriteLine(HttpUtility.HtmlDecode(htmlMessage));
            WriteLine("-----------------------");
            return Task.CompletedTask;
        }
    }
}
