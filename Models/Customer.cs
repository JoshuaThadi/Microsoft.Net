namespace CustomerManagement.Models
{
    public class Customer : UserActivity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
    }
}
