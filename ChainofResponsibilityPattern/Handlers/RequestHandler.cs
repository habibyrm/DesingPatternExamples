using ChainofResponsibilityPattern.Models;

namespace ChainofResponsibilityPattern.Handlers
{
    public abstract class RequestHandler
    {
        protected RequestHandler nextHandler;

        public void SetNext(RequestHandler handler)
        {
            nextHandler = handler;
        }

        public void Handle(Request request)
        {
            if (ProcessRequest(request) && nextHandler != null)
            {
                nextHandler.Handle(request);
            }
        }

        protected abstract bool ProcessRequest(Request request);
    }
}
