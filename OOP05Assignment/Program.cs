using OOP05Assignment.First_Project;
using OOP05Assignment.Second_Project;
using OOP05Assignment.third_Project;

namespace OOP05Assignment
{
    internal class Program
    {
        static _3DPoint ReadPoint(string Point)
        {
            double x, y, z;
            x = ReadDouble($"{Point}.X");
            y = ReadDouble($"{Point}.Y");
            z = ReadDouble($"{Point}.Z");
            return new _3DPoint( x, y, z );
        }
        static double ReadDouble(string Coordinate) 
        {
            double value = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.WriteLine($"Enter {Coordinate}");
                string input = Console.ReadLine();

                // Try Using Convert
                try
                {
                    value = Convert.ToDouble(input);
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Convert failed. Please enter a valid number.");
                }

                // Try using double.TryParse
                if (!isValid && double.TryParse(input, out value))
                {
                    isValid = true;
                }
                else if (!isValid)
                {
                    Console.WriteLine("TryParse failed. Please enter a valid number.");
                }

                // Try Using Parse
                if (!isValid)
                {
                    try
                    {
                        value = double.Parse(input);
                        isValid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Parse failed. Please enter a valid number.");
                    }
                }
            }
            return value;

        }          
        static int ComparePoints( _3DPoint point1, _3DPoint point2)
        {
            int result = point1.X.CompareTo(point2.X);
            if(result == 0)
            {
                result = point1.Y.CompareTo(point2.Y);
            }
            return result;
        }

        static void Main(string[] args)
        {
            #region First Project

            #region (Q1 & Q2)
            //_3DPoint P = new _3DPoint(10, 10, 10);
            //Console.WriteLine(P.ToString());
            //Console.WriteLine(); 
            #endregion

            #region Q3
            //Console.WriteLine("Enter the coordinates of the first Point p1(x,y,z)");
            //_3DPoint p1 = ReadPoint("P1");
            //Console.WriteLine("Enter the coordinates of the second Point p1(x,y,z)");
            //_3DPoint p2 = ReadPoint("P2");
            //Console.WriteLine(); 
            #endregion

            #region Q4
            //if (p1 == p2)
            //{
            //    Console.WriteLine("P1 and P2 are equal.");
            //}
            //else
            //{
            //    Console.WriteLine("P1 and P2 are not equal.");
            //} 

            #endregion

            #region Q5

            //_3DPoint[] points = new _3DPoint[]
            //{
            //     new _3DPoint(10,20,30),
            //     new _3DPoint(4,7,1),
            //     new _3DPoint(5,9,3)

            //};

            //Array.Sort(points, ComparePoints);
            //Console.WriteLine("Sorted Points: ");
            //foreach (_3DPoint point in points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion



            #endregion

            #region Second Project
            //Console.WriteLine(Maths.Add(10,20));
            //Console.WriteLine(Maths.Subtract(10, 20));
            //Console.WriteLine(Maths.Multiply(10, 20));
            //Console.WriteLine(Maths.Divide(10, 20));

            #endregion

            #region Third Project
            #region (Q3)
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString()); 
            #endregion

            #region (Q4)

            //Duration d1 = new Duration(1, 10, 15);
            //Duration d2 = new Duration(3600);
            //Duration d3;


            //d3 = d1 + d2;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 2, Minutes: 10, Seconds: 15

            //d3 = d1 + 7800;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 3, Minutes: 10, Seconds: 15

            //d3 = 666 + d2;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 1, Minutes: 6, Seconds: 0

            //d3 = ++d1;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 1, Minutes: 11, Seconds: 15

            //d3 = --d2;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 0, Minutes: 59, Seconds: 0

            //d3 = d1 - d2;
            //Console.WriteLine(d3.ToString()); // Output: Hours: 0, Minutes: 10, Seconds: 15

            //Console.WriteLine(d1 > d2); // Output: True
            //Console.WriteLine(d1 <= d2); // Output: False

            //DateTime dateTime = (DateTime)d1;
            //Console.WriteLine(dateTime); // Output: today's date plus the duration

            #endregion


            #endregion

        }
    }
}
