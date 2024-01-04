using Microsoft.AspNetCore.Identity;

namespace DocGems.Data;

public class User : IdentityUser
{
    //public string Id { get; set; }
    public List<UserDocument> UserDocuments { get; set; }
}