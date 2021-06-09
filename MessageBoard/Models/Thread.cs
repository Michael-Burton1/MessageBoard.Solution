// using System.Collections.Generic;

// namespace MessageBoard.Models
// {

//   public class Thread
//   {
//     private static List<Thread> _instances = new List<Thread> { };
//     // This was a global property, acting as our database. Every time we created a Thread, we pushed the entire instance of a thread to this list. 
//     public string Name { get; set; }
  
//     public int Id { get; }
//     public List<Message> Messages { get; set; }
//     // Every time we create a thread, we are also creating an empty list of Messages specific to that Thread. Thread.Messages <- 
//     // public ICollection<Message> Messages {get; set; }

//     public Thread(string threadName)
//     {
//       Name = threadName;
//       _instances.Add(this);
//       Id = _instances.Count;
//       Messages = new List<Message>{};
//     }
//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }
//     public static List<Category> GetAll()
//     {
//       return _instances;
//     }
//     public static Category Find(int searchId)
//     {
//       return _instances[searchId-1];
//     }
//     public void AddItem( Item item )
//     {
//       Items.Add(item);
//     }
//   }
// }