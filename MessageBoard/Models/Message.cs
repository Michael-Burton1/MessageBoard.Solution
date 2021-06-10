using System.ComponentModel.DataAnnotations;
using System;

namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Text { get; set; }
    [Required]
    [StringLength(20)]
    public string Author { get; set; }
    
    //public int ThreadId {get;set} <-- we would need this if we were doing doing a one to many relationships.
  }
}