//ЗАДАНИЕ 1
class metod
{
    public static void SortPoVoz(int[] array)
    {
        Array.Sort(array);
    }
    public static void SortPoYbv(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
    }
    public static int[] ObArray(int[] array1, int[] array2)
    {
        int[] arrayfinish = new int[array1.Length + array2.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            arrayfinish[i] = array1[i];
        }
        for (int j = 0; j < array2.Length; j++)
        {
            arrayfinish[array1.Length + j] = array2[j];
        }
        return arrayfinish;
    }

}
//ЗАДАНИЕ 2
class z2
{
    static void Main(string[] args)
    {
        Console.WriteLine("введите целое число n:");
        int n = int.Parse(Console.ReadLine());
        static int AbsD(int n)
        {
            int absrazn = Math.Abs(n - 123);
            return n > 123 ? absrazn * 3 : absrazn;
        }
        int result = AbsD(n);
        Console.WriteLine($"Результат: {result}");
    }
    
}
