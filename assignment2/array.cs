using System;

class ArrayOperate
{
    static int[] arr;
    public void operate(out int min, out int max, out double average, out int sum)
    {
        min = max = arr[0];//初始化
        sum = 0;
        int num = 0;
        foreach (int i in arr)
        {
            num++;
            sum += i;
            if (i >= max)
            {
                max = i;
            }
            if (i <= min)
            {
                min = i;
            }
        }
        average = (double)sum / num;
    }

    public void buildArray(int num)
    {
        arr = new int[num];
        for (int i = 0; i < num; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("the array is :");//显示数组
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }//建

    static void Main()
    {
        int min, max, sum;
        double average;
        ArrayOperate a1 = new ArrayOperate();
        Console.WriteLine("plase input the arange of the arra:");
        int arrnum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("plase input the num of the array:(）");
        a1.buildArray(arrnum);
        a1.operate(out min, out max, out average, out sum);
        Console.WriteLine("min:" + min + "; " + "max:" + max + "; " +
            "average:" + average + "; " + "sum:" + sum);
    }
}