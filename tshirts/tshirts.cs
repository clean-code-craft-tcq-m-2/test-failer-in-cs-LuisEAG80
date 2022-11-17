using System;
using System.Diagnostics;

namespace TshirtSpace {
    class Tshirt {
        static string Size(int cms) {
            if(cms < 38) {
                return "S";
            } else if(cms > 38 && cms < 42) {
                return "M";
            } else {
                return "L";
            }
        }
        static void Main(string[] args) {
            Debug.Assert(Size(37) == "S"); // Below boundary
            Debug.Assert(Size(38) == "M"); // boundary
            Debug.Assert(Size(39) == "M"); // above boundary
            Debug.Assert(Size(41) == "M"); // Below boundary 
            Debug.Assert(Size(42) == "M"); // boundary
            Debug.Assert(Size(43) == "L"); // above boundary
            Console.WriteLine( "All is well (maybe!)");
        }
    }
}
