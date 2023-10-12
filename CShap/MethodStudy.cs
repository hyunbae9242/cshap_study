

namespace MyApp
{
    internal class MethodStudy
    {
       
        static int Add(int a, int b){
            return a+b;
        }

        static void AddOne(ref int number){
            number++;
        }

        static void Main(string[] args) {
            int result = MethodStudy.Add(4,10);
            Console.WriteLine(result);

            int i = 0;
            MethodStudy.AddOne(ref i);
            Console.WriteLine(i);
        }
    }
}