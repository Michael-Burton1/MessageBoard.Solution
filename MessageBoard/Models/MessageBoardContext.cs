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
              new Message { MessageId = 1, Subject= "Beach safety", Text = "Don't forget to bring a towel", Author = "Towelly", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc) },
              new Message { MessageId = 2, Subject= "Shut up", Text = "Shut it up, you", Author = "StrongBad", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc) },
              new Message { MessageId = 3, Subject="Mammoth shaming", Text = "It's not a coat!", Author = "Woolly Mammoth", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc) },
              new Message { MessageId = 4, Subject="Manitee shaming", Text = "I'm a manitee, I have a layer of blubber to keep me warm.", Author = "Sea Cow", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc) },
              new Message { MessageId = 5, Subject="Christmas carol remix", Text = "Oh Holy Crap!", Author = "StrongBad", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc) }
            
          );
      builder.Entity<Event>()
          .HasData(
              new Event { EventId = 1, Name = "My son's 7th bday", Category = "Birthday", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= true},
              new Event { EventId = 2, Name = "Mushrooms?", Category = "Ted Talk", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= false},
              new Event { EventId = 3, Name = "The Grateful Dead", Category = "Concert", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= true},
              new Event { EventId = 4, Name = "Generationals", Category = "Concert", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= true},
              new Event { EventId = 5, Name = "Where's your hand?", Category = "A saucey puppet show", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= true},
              new Event { EventId = 6, Name = "David Sedaris: Me Talk Pretty One Day", Category = "Book signing", Date = new DateTime(2021, 06, 09, 10, 30, 00, DateTimeKind.Utc), Booze= false}
              
            
          );
    }
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
    public DbSet<Event> Events { get; set; }
  }
}
