using System.Runtime.InteropServices;

var headlinesColumn = new List<string> { "Type", "Byte(s) of memory", "Min", "Max" };

var headline = $"{headlinesColumn[0],-8}{headlinesColumn[1],-20}{headlinesColumn[2],14}{headlinesColumn[3],31}";

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
    Console.WriteLine($"{type.Name.ToLower(),-8}{Marshal.SizeOf(type)}{type.GetField("MinValue")?.GetValue(null),33}" +
        $"{type.GetField("MaxValue")?.GetValue(null),31}");
}

Seperate(headline);

static void Seperate(string headline)
{
    Console.WriteLine(new string('-', headline.Length));
}
