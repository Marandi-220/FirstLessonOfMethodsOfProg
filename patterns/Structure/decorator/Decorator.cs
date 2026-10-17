using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.decorator
{
    public class Decorator
    {
        public static void Run()
        {
            EncryptionNoteService service = new EncryptionNoteService();

            service.PutNote(1, " 11");
            service.PutNote(1, "12");
            service.PutNote(2, "2");

            List<string> notes = service.GetNotes(1);
            foreach(string note in notes)
            {
                Console.WriteLine(note);
            }
        }
    }
}
