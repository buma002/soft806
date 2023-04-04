namespace IdentityDemo.Models
{
    public class Errors
    {
        public string? ReQid { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(ReQid);
    }
}