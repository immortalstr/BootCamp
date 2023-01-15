
using static System.Console;
using static System.String;
public static class Infrastructure
{
    public static int[] CraeteArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
               .Select(itrm => Random.Shared.Next(min, max))
               .ToArray();
    }
    public static void Show(int[] array)
    {
        WriteLine($"[{String.Join(',', array)}]");
    }
}