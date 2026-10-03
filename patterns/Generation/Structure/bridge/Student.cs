using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.bridge
{
    public class Student
    {
        public string Name;
        public int NumberOfGroup;
        readonly Decanat decanat;
        public Student(string name, int id, Decanat dec)
        {
            Name = name;
            NumberOfGroup = id;
            decanat = dec;
        }
        public void GetMessageFromTeacher()
        {
            Console.WriteLine("messages from teacher");
            List<string> messages = decanat.ReceiveMessageForStudent(this);
            foreach (string m in messages)
            {
                Console.WriteLine(m);
            }
        }

        public void SendMessageToTeacher(Teacher teacher, string message)
        {
            decanat.SendMessageToTeacher(teacher, message);
        }

    }
}
