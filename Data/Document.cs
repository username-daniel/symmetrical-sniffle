using System.ComponentModel.DataAnnotations.Schema;

namespace DocGems.Data;

public class Document
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string Id { get; set; }
    
    public string title { get; set; }
    
    public string genericId { get; set; }
    
    public DateTime created { get; set; }
    
    public int readCounter { get; set; }
    
    public List<UserDocument> UserDocuments { get; set; }
}
