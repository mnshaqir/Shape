using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Rectangle
    {
        // Property (Inheritance)
        //new = overwrite width/height in the rectangle
        //base 
        public new double Width
        {
            get { return base.Width; }
            set 
            { 
                base.Width = value;
                base.Height = value;
            }
        }

        public new double Height
        {
            get { return base.Height; }
            set 
            { 
                base.Height = value;
                base.Width = value;
            }
        }

        public double Len
        {
            get { return base.Height; }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }


        public Square(): base()
        {
        }

        public Square(double len): base(len, len)
        { 
        }

    }
}
