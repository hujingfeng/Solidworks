using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solidworks_Features
{
    class FileClass
    {
        public static void TestFunction(string FilePath)
        {
            Console.WriteLine(FilePath);
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary1 = new Dictionary<int, string>();
            Dictionary<int, string> myDictionary2 = new Dictionary<int, string>();

            myDictionary1.Add(4, "Arc");
            myDictionary1.Add(11, "Cylinder");
            myDictionary1.Add(14, "Dimension");
            myDictionary1.Add(5, "Ellipse");
            myDictionary1.Add(8, "Hatch");
            myDictionary1.Add(3, "Line");
            myDictionary1.Add(6, "Parabola");
            myDictionary1.Add(10, "Plane");
            myDictionary1.Add(2, "Point");
            myDictionary1.Add(12, "Sphere");
            myDictionary1.Add(7, "Spline");
            myDictionary1.Add(1, "SubSketch");
            myDictionary1.Add(13, "Surface");
            myDictionary1.Add(9, "Text");
            myDictionary1.Add(0, "Unknown");
            myDictionary2.Add(0, "All");
            myDictionary2.Add(6, "Broken");
            myDictionary2.Add(1, "Dangling");
            myDictionary2.Add(4, "Context");
            myDictionary2.Add(3, "External");
            myDictionary2.Add(5, "Locked");
            myDictionary2.Add(2, "Defining");
            myDictionary2.Add(7, "Entities");
        }

    }
}
