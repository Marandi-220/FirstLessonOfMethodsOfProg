using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.bridge
{
    public class Teacher
    {
        public string Name;
        public int Id;
        readonly Decanat decanat;
        public Teacher(string name, int id, Decanat dec)
        {
            Name = name;
            Id = id;
            decanat = dec;
        }
        public void GetMessageFromStudents()
        {
            Console.WriteLine("messages from students");
            List<string> messages = decanat.ReceiveMessageForTeacher(this);
            foreach (string m in messages)
            {
                Console.WriteLine(m);
            }
        }
        public void SendMessageToStudents(int numberOfGroup, string message)
        {
            decanat.SendMessageToStudent(numberOfGroup, message);
        }
    }
}
