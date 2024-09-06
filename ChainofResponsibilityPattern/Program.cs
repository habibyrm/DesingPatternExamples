using ChainofResponsibilityPattern.Handlers;
using ChainofResponsibilityPattern.Models;

//Creat handlers
RequestHandler authHandler = new AuthenticationHandler();
RequestHandler authzHandler = new AuthorizationHandler();
RequestHandler loggingHandler = new LoggingHandler();
RequestHandler businessHandler = new BusinessLogicHandler();

// Chain them together
authHandler.SetNext(authzHandler);
authzHandler.SetNext(loggingHandler);
loggingHandler.SetNext(businessHandler);

// Create a valid request
var validRequest = new Request
{
    AuthToken = "valid_token",
    UserId = "user123",
    UserRole = "Admin",
    Endpoint = "/api/data"
};

// Process the request through the chain
Console.WriteLine("Processing valid request:");
authHandler.Handle(validRequest);

Console.WriteLine();

// Create an invalid request (wrong role)
var invalidRequest = new Request
{
    AuthToken = "valid_token",
    UserId = "user123",
    UserRole = "User", // Not an Admin
    Endpoint = "/api/data"
};

// Process the invalid request through the chain
Console.WriteLine("Processing invalid request:");
authHandler.Handle(invalidRequest);