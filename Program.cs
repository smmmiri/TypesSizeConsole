using System.Runtime.InteropServices;

var headlineColumns = new List<string> { "Type", "Byte(s) of memory", "Min", "Max" };

var headline = $"{headlineColumns[0],-8}{headlineColumns[1],-20}{headlineColumns[2],15}{headlineColumns[3],31}";

Seperate(headline);
Console.WriteLine(headline);
Seperate(headline);

var types = new List<Type>
{
    typeof(sbyte),
    typeof(byte),
    typeof(short),
    typeof(ushort),
    typeof(int),
    typeof(uint),
    typeof(long),
    typeof(ulong),
    typeof(float),
    typeof(double),
    typeof(decimal)
};

foreach (var type in types)
{
    Console.WriteLine($"{type.Name.ToLower(),-8}{Marshal.SizeOf(type),-5}" +
        $"{type.GetField("MinValue")?.GetValue(null),30}{type.GetField("MaxValue")?.GetValue(null),31}");
}

Seperate(headline);

Console.WriteLine("\nPress any key to exit . . .");
Console.ReadLine();

static void Seperate(string headline)
{
    Console.WriteLine(new string('-', headline.Length));
}
