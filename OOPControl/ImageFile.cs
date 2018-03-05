using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControl
{
    public class ImageFile : FileClass
    {

        

        public string Resolution { get; set; }

        public ImageFile(string name,
                        string extension,
                        string size,
                        string resolution) :

                        base(name, extension, size)
        {
            this.Resolution = resolution;
        }

        public override void PrintFileInfo()
        {
            throw new NotImplementedException();
        }

        public override void ParseAllAtributes()
        {
            base.ParseAllAtributes();
        }

        public string SearchingForResolution(string text)
        {
            string resolution = "";
            string size = SearchForTheSize(text);

            for (int i = text.IndexOf(";") + 1; i < text.Length - 1; i++)
            {
                resolution += i;
            }
            return resolution;
        }


    }
}
