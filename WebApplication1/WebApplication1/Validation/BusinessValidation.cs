using System.Text.RegularExpressions;

namespace StatusRetrievalApplication.Validation
{
    public static class BusinessValidation
    {
        public static bool ValidateEmailPattern(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(emailAddress);
        }
    }
}
