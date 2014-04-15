using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public class Field
    {
        private char[] field={'1','2','3','4','5','6','7','8','9'};

        public void set_fieldcontent(int fieldnumber,char mark) 
        {
            field[fieldnumber-1] = mark;
        }

        public char get_fieldcontent(int fieldnumber)
        { 
            return this.field[fieldnumber];
        }

        public bool is_free(int fieldnumber)
        {
            int fieldcontent = this.field[fieldnumber-1]; //char!!!!!!!!!!!!!
            if ((fieldcontent) > 0 && (fieldcontent) < 10)
                return true;
            else
                return false;
        }
    }
}
