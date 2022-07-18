using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Class1
    {
        interface IFile
        {
            void ReadFile();
            void WriteFile(string text);
        }

        class FileInfo : IFile
        {
            void IFile.ReadFile()
            {
                Console.WriteLine("dfghj");
            }

            public void WriteFile(string text)
            {
                Console.WriteLine("writing File");
            }

            public void Searching(string text)
            {
                Console.WriteLine("Search file");
            }
        }
    }

}
