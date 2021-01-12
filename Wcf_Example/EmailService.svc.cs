using System.Text.RegularExpressions;

namespace Wcf_Example
{
    // NOTE: In order to launch WCF Test Client for testing this service, select IEmailService.svc at the Solution Explorer and run it.
    public class EmailBO : IEmailService
    {
        public bool ValidateEmail(string email)
        {
            string isValidEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, isValidEmail);
        }
    }
}
