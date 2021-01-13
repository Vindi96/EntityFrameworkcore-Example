using System;

namespace NoteAPP
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new NoteContext(@"Data Source=DESKTOP-UR4UBIL\SQLEXPRESS;Initial Catalog=NoteBook;Integrated Security=True");
            var provider = new NoteProvider(context);
            var note = provider.Get(1);
            Console.WriteLine($"{ note.Title}");
            Console.WriteLine($"{ note.Content}");

            Console.WriteLine($"enter the new title:");

            var repo = new NoteRepo(context);
            var note1= provider.Get(1);
            note1.Title=Console.ReadLine();
            repo.Update(note1);

            Console.WriteLine("Create new record ");

            Console.Write($"Enter First Name:");
            String firstName=Console.ReadLine();

            Console.WriteLine($"Enter Last Name: ");
            String lastName  =Console.ReadLine();

            Console.WriteLine($"Enter Title: ");
            String title =Console.ReadLine();

            Console.WriteLine($"Enter Content: ");
            String content =Console.ReadLine();
            repo.Create(firstName,lastName,title,content);

            Console.WriteLine($"Enter note ID to dlete: ");

            
            String dltnum=Console.ReadLine();
            int dltId=Int32.Parse(dltnum);
            var dlnote= provider.Get(dltId);
            repo.Delete(dlnote);



        }
    }
}
