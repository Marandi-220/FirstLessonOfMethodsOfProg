using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.decorator
{
    internal interface INoteService
    {
        List<string> GetNotes(int id);

        void PutNote(int id, string note);
    }
}
