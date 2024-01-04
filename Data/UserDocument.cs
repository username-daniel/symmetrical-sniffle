using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DocGems.Data;

public class UserDocument
{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }

    public string DocumentId { get; set; }
    public Document Document { get; set; }

    public string AdditionalInfo { get; set; }
    
    public string Content { get; set; }
    public DateTime updated { get; set; }
    public bool deprecated { get; set; }
}