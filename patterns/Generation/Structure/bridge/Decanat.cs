using patterns.Generation.abstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.bridge
{
    public class Decanat
    {
        public Dictionary<int, List<string>> MessageForStudents = new Dictionary< int, List<string> >();
        public Dictionary<int, List<string>> MessageForTeacher = new Dictionary< int, List<string> >();
        public Decanat() { }
        public List<string> ReceiveMessageForTeacher(Teacher teacher)
        {
            List<string> mess = MessageForTeacher[teacher.Id];
            MessageForTeacher.Clear();
            return mess;
        }
        public List<string> ReceiveMessageForStudent(Student student)
        {
            List<string> mess = MessageForStudents[student.NumberOfGroup];
            MessageForStudents.Clear();
            return mess;
        }

        public void SendMessageToStudent(int NumberOfGroup, string message)
        {
            if (MessageForStudents.ContainsKey(NumberOfGroup))
            {
                MessageForStudents[NumberOfGroup].Add(message);
            }
            else
            {
                List<string> messages = new List<string>();
                messages.Add(message);
                MessageForStudents.Add(NumberOfGroup, messages);
            }
        }

        public void SendMessageToTeacher(Teacher teacher, string message)
        {
            if (MessageForTeacher.ContainsKey(teacher.Id))
            {
                MessageForTeacher[teacher.Id].Add(message);
            }
            else
            {
                List<string> messages = new List<string>();
                messages.Add(message);
                MessageForTeacher.Add(teacher.Id, messages);
            }
        }

    }
}
