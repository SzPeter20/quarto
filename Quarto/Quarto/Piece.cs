using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarto
{
    class Piece
    {
        public string Large { get; set; }
        public string Blue { get; set; }
        public string Circle { get; set; }
        public string B { get; set; }

        public Piece(string large, string blue, string circle, string b)
        {
            Large = large;
            Blue = blue;
            Circle = circle;
            B = b;
        }
    }
}
