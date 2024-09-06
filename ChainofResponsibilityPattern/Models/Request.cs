namespace ChainofResponsibilityPattern.Models
{
    public class Request
    {
        public string AuthToken { get; set; }
        public string UserId { get; set; }
        public string UserRole { get; set; }
        public string Endpoint { get; set; }
    }
}
