using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControl
{
    public class TextFile : FileClass
    {
        public string Content { get; set; }
        
        public TextFile(string name,
                        string extension,
                        string size,
                        string content):

                        base(name,extension,size)
        {
            this.Content = content;
        }

        public override void PrintFileInfo()
        {
            Console.WriteLine($"");
        }

        
    }
}
