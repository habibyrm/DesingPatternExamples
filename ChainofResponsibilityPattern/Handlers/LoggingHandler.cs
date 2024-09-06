using ChainofResponsibilityPattern.Models;

namespace ChainofResponsibilityPattern.Handlers
{
    public class LoggingHandler : RequestHandler
    {
        protected override bool ProcessRequest(Request request)
        {
            Console.WriteLine($"Logging request: {request.Endpoint} from user {request.UserId}");
            return true;
        }
    }
}
