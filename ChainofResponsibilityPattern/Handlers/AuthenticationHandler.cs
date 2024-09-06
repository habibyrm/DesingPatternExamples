using ChainofResponsibilityPattern.Models;

namespace ChainofResponsibilityPattern.Handlers
{
    public class AuthenticationHandler : RequestHandler
    {
        protected override bool ProcessRequest(Request request)
        {
            if (request.AuthToken == "valid_token")
            {
                Console.WriteLine("Authentication successful.");
                return true;
            }
            else
            {
                Console.WriteLine("Authentication failed.");
                return false;
            }
        }
    }
}
