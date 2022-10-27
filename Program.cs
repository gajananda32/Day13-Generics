using MaxM;
using System.Collections.Generic;

GenericMax<int> a = new GenericMax<int>(25, 35, 65);
Console.WriteLine("the maximum value is: " + a.MaxMethod);
GenericMax < double> b = new GenericMax<double>(224.23, 106.23, 420.65);
Console.WriteLine("the maximum value is: " + b.MaxMethod);
GenericMax<string> c = new GenericMax<string>("saaho","kgf","Endgame");
Console.WriteLine("the maximum value is: " + c.MaxMethod);
