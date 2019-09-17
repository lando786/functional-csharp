using System.Linq;
using System;
namespace functional_csharp.Chapter1
{
    public static class test
    {
        public static void Run(){
            var list = Enumerable.Range(1,5);
            foreach(var x in list){
            Console.WriteLine(x);
            }
        }
    }
}