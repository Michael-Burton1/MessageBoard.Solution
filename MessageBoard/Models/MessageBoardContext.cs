using Microsoft.EntityFrameworkCore;
using System;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Message>()
          .HasData(
              new Message { MessageId = 1, Subject= "Beach safety", Text = "Don't forget to bring a towel", Author = "Towelly"},
              new Message { MessageId = 2, Subject= "Shut up", Text = "Shut it up, you", Author = "StrongBad"},
              new Message { MessageId = 3, Subject="Mammoth shaming", Text = "It's not a coat!", Author = "Woolly Mammoth"},
              new Message { MessageId = 4, Subject="Manitee shaming", Text = "I'm a manitee, I have a layer of blubber to keep me warm.", Author = "Sea Cow"},
              new Message { MessageId = 5, Subject="Christmas carol remix", Text = "Oh Holy Crap!", Author = "StrongBad"}
            
          );
     
    }
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
    
  }
}
