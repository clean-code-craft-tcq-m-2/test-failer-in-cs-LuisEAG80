using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        static string[] printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            string[] colorMapRows = new string[majorColors.Length * minorColors.Length];

            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    colorMapRows[i * 5 + j] = string.Format("{0} | {1} | {2}", i * 5 + j, majorColors[i], minorColors[j]);
                }
            }

            Console.WriteLine("{0}", string.Join(Environment.NewLine, colorMapRows));
            return colorMapRows;
        }

        static void Main(string[] args) {
            string[] result = printColorMap();
            Debug.Assert(result.Length == 25);

            foreach (var row in result)
            {
                Debug.Assert(row.IndexOf("|") == 3);
            }

            Console.WriteLine("All is well (maybe!)");
        }
    }
}
