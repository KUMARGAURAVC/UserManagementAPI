namespace UserManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; } // Made nullable
        public string? Email { get; set; } // Made nullable
    }
}