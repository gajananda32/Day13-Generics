using MoreThan3Para;

int[] intArray = { 110, 450, 420, 5, 666 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "111", "222", "333", "55", "999" };

GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();
