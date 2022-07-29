using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.System.Console.Write
            Console.Write("Hello world!\n");

            String s1 = "Hello world!\n";
            Console.Write(s1);

            //2.System.Console.WriteLine
            //Write와 하는 일은 같지만 개행문자 \n 가 추가되서 문자열이나 변수 등을 출력할 때 편리
            Console.WriteLine("Hello world!");

            //문자열 결합(concatenate)은 + 연산자를 사용
            Console.WriteLine("Hello" + " world!");

            //정답
            String s2;
            String s3;

            Console.Write("input s1 : ");
            s2 = System.Console.ReadLine();
            Console.Write("input s2 : ");
            s3 = System.Console.ReadLine();

            Console.WriteLine("the string is \n{0},{1}", s2, s3);
            Console.WriteLine($"the string is \n{s2},{s3}");
            Console.WriteLine(@"the string is {0},{1}", s2, s3);
            Console.WriteLine($@"the string is {s1},{s3}");

            Console.ReadKey();
        }
    }
}

/*
    1. System.Console.Write 2번
    2. System.Console.ReadLine 2번
    3. System.Console.WriteLine 4번

    서로 다른 WriteLine을 이용해서 모두 같은 결과가 나오도록 실행
*/