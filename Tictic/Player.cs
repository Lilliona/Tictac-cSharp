using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tictic
{
    public abstract class Player
    {
        public abstract int get_fieldtarget(Field field,char opponent, char actual_player);
    }
}
