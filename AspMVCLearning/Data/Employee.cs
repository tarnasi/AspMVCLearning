using Microsoft.AspNetCore.Identity;

namespace AspMVCLearning.Data
{
    public class Employee : IdentityUser
    {
        public string? Firstname { get; set; }
        public string? Lastanme { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
