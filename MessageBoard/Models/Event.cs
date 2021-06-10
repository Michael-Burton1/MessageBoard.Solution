using System.ComponentModel.DataAnnotations;
using System;
// using System.Boolean;

namespace MessageBoard.Models
{
  public class Event
  {
    public int EventId {get; set;}
    [Required]
    public string Name  {get; set;}
    [Required]
    public string Category {get; set;}
    [Required]
    public DateTime Date {get; set;}
    [Required]
    public bool Booze {get; set;}
  }
}