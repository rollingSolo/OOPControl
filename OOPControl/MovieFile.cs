using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPControl
{
    public class MovieFile : ImageFile
    {


        
        public string Duration { get; set; }


        public MovieFile(string name,
                        string extension,
                        string size,
                        string resolution,
                        string duration) :

                        base(name, extension, size, resolution)
        {
            this.Duration = duration;
        }

        public override void PrintFileInfo()
        {
            throw new NotImplementedException();
        }

       
    }
}
