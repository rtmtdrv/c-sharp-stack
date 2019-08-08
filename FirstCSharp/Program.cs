using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArr = {1,2,3};
            Console.WriteLine("Hello World!");
            Console.WriteLine(sigma(5));
            Console.WriteLine(average(newArr));
        }

        public static int sigma(int num){
            int sum = 0;
            for(int i = 0;i <= num; i++){
                sum += i;
            }
            return sum;
        }
        
        public static double average(int[] arr){
            double avg = 0;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                sum += arr[i];
            }
            avg = sum/arr.Length;
            return avg;
        }

    }
}
