using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControl
{
    public abstract class FileClass
    {
        public string FileName { get; }
        public string Extension { get; }
        public string Size { get; }

        public Char[] trimSeparators = new char[] { '/','@',',','-',' ','\t','\n',';'};
        

        public FileClass(string fileName,string extension,string size)
        {
            this.FileName = fileName;
            this.Extension = extension;
            this.Size = size;
        }


        public string SearchForTheFileName(string text)
        {
            string fileName = "";
            string extension = SearchForTheExtension(text);

            for (int i = text.IndexOf(":"); i < text.IndexOf(extension) - 1; i++)
            {
                fileName += i;
            }

            return fileName.Trim(trimSeparators);
        }

        public string SearchForTheExtension(string text)
        {
            string extension = "";

            for (int i = text.IndexOf(".") + 1; i < text.IndexOf("("); i++)
            {
                extension += i;
            }

            return extension;
        }

        public string SearchForTheSize(string text)
        {
            string size = "";
            string extension = SearchForTheExtension(text);
            for (int i = text.IndexOf(extension) + 1; i < text.IndexOf(")"); i++)
            {
                size += i;
            }

            
            return size;

        }


        public abstract void PrintFileInfo();
        public virtual void ParseAllAtributes()
        {

        }

        


        



    }
}
