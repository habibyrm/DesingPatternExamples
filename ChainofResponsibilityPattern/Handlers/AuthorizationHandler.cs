using ChainofResponsibilityPattern.Models;

namespace ChainofResponsibilityPattern.Handlers
{
    public class AuthorizationHandler : RequestHandler
    {
        protected override bool ProcessRequest(Request request)
        {
            if (request.UserRole == "Admin")
            {
                Console.WriteLine("Authorization successful.");
                return true;
            }
            else
            {
                Console.WriteLine("Authorization failed.");
                return false;
            }
        }
    }
}
