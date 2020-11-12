namespace ZwajApp.API.Models
{
    public class User
    {
        public int ID { get; set; } 
        public string Username { get; set; }     
        public byte[] PassworHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}