using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace patterns.Structure.decorator
{
    public class EncryptionNoteService : INoteService
    {
        //НЕ РАБОТАЕТ!!!
        public NoteService NoteService = new NoteService();
        private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048);
        

        public string Encrypth(string msg)
        {
            byte[] plainBytes = System.Text.Encoding.UTF8.GetBytes(msg);
            var result = rsa.Encrypt(plainBytes, false);
            return Convert.ToBase64String(result);
        }

        public string DeCrypth(string msg)
        {
            byte[] encryptedData = System.Text.Encoding.UTF8.GetBytes(msg);
            rsa.FromXmlString(rsa.ToXmlString(true));
            byte[] decryptedBytes = rsa.Decrypt(encryptedData, true);

            return System.Text.Encoding.UTF8.GetString(decryptedBytes);

        }

        public List<string> GetNotes(int id)
        {
            return NoteService.GetNotes(id).Select(x => DeCrypth(x)).ToList();

        }

        public void PutNote(int id, string note)
        {
            string encryptednote = Encrypth(note);
            this.NoteService.PutNote(id, encryptednote);
        }
    }
}
