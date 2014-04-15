using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*TODO: check fieldcontentvalues*/

namespace Tictic
{
    public class Field
    {
        private char[] field={'1','2','3','4','5','6','7','8','9'};

        public void set_content(int fieldnumber,char mark) 
        {
            field[fieldnumber-1] = mark;
        }

        public char get_content(int fieldnumber)
        { 
            return this.field[fieldnumber];
        }

        public bool is_free(int fieldnumber)
        {
            char fieldcontent = this.field[fieldnumber-1];

            if (fieldcontent == 'X' || fieldcontent == 'O')
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
