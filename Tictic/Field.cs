using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Field
    {
        private char[] field={'1','2','3','4','5','6','7','8','9'};

        public char get_fieldcontent(int fieldnumber)
        { 
            return this.field[fieldnumber];
        }
    }
}
