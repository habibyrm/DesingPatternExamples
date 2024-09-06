using ChainofResponsibilityPattern.Models;

namespace ChainofResponsibilityPattern.Handlers
{
    public class BusinessLogicHandler : RequestHandler
    {
        protected override bool ProcessRequest(Request request)
        {
            Console.WriteLine($"Executing business logic for request: {request.Endpoint}");
            return true;
        }
    }
}
