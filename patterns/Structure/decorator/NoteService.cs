using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.decorator
{
    public class NoteService : INoteService
    {
        public Dictionary<int, List<string>> Notes = new Dictionary<int, List<string>>();
        public List<string> GetNotes(int id)
        {
            if (Notes.ContainsKey(id))
            {
                return Notes[id];
            }
            else
            {
                return new List<string>();
            }
        }

        public void PutNote(int id, string note)
        {
            if (Notes.ContainsKey(id))
            {
                Notes[id].Add(note);
            }
            else
            {
                Notes.Add(id, new List<string>());
                Notes[id].Add(note);
            }

        }
    }
}
