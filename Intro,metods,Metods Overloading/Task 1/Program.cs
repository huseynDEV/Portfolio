//int[] arr = { 2, 34, 4, 56, 9, 54 };
//int b = 0;
//int c = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (i > 9 && i < 100)
//    {
//        b++;
//    }
//}

class program
{

    static void Main(string[] arr)
    {
        int[] eded = { 1, 2, 6, 14, 25 };
        int c = 5;
        int d = 15;
        CustomArrResize(ref eded, c, d);
        for (int i = 0; i < eded.Length; i++)
        {
            Console.WriteLine(eded[i]);
        }

    }

    static void CustomArrResize(ref int[] arr, params int[] num)
    {
        int[] newArr = new int[arr.Length + num.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        for (int i = 0; i < num.Length; i++)
        {
            newArr[arr.Length + i] = num[i];

        }
        arr = newArr;


    }
}