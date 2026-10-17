using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.composite
{
    public class Composite
    {
        public static void Run()
        {
            #region var1
            Folder folderMain = new Folder();

            Folder folder1 = new Folder();
            File file11 = new File();
            file11.Size = 1;
            File file12 = new File();
            file12.Size = 1;
            File file13 = new File();
            file13.Size = 1;
            folder1.Files.Add(file11);
            folder1.Files.Add(file12);
            folder1.Files.Add(file13);

            Folder folder2 = new Folder();
            File file21 = new File();
            file21.Size = 1;
            File file22 = new File();
            file22.Size = 1;
            File file23 = new File();
            file23.Size = 1;
            folder1.Files.Add(file21);
            folder1.Files.Add(file22);
            folder1.Files.Add(file23);

            Folder folder3 = new Folder();
            Folder folder31 = new Folder();
            folder3.Folders.Add(folder31);
            File file311 = new File();
            file311.Size = 1;
            folder31.Files.Add(file311);

            folderMain.Folders.Add(folder1);
            folderMain.Folders.Add(folder2);
            folderMain.Folders.Add(folder3);

            //Console.WriteLine(folderMain.GetSize());

            #endregion

            #region var2
            Folder folderMain2 = new Folder();
            for (int i = 0; i < 3; i++)
            {
                folderMain2.Folders.Add(new Folder());
            }
            Random rnd = new Random();
            int sum = 0;
            foreach (Folder folder in folderMain2.Folders)
            {
                for (int i = 0; i < 3; i++)
                {
                    File file = new File();
                    file.Name = folder.Name + rnd.Next(10).ToString();
                    file.Size = rnd.Next(100);

                    Console.WriteLine($"{sum} + {file.Size} = {sum+file.Size}");
                    sum += file.Size;

                    folder.Files.Add(file);
                }
            }

            Console.WriteLine(folderMain2.GetSize());


            #endregion
        }
    }
}
