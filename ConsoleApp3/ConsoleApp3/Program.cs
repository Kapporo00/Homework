using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; // System.Console 생략

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1;

            Write("input s1 :");

            s1 = ReadLine();

            //WriteLine("s1 is {0}", s1);

            // string을 int로 변환
            int intValue1 = Convert.ToInt32(s1);
            /*
            변환 방법 3가지
            1. Conver.Toint32()
            2. int.Parse()
            3. int.TryParse()
            */

            // int를 float으로 변환
            int s2 = intValue1;

            float s3 = (float)s2;

            // float을 string으로 변환
            string s4 = s3.ToString();

            WriteLine("{0} is int\n{1} is float\n{2} is string",s2,s3,s4);

            // 정답
            Write("===================================================\n");

            string s5;

            Write("input1 : ");
            s5 = ReadLine();

            int int1 = int.Parse(s5);

            float flo1 = (float)int1;

            string ss = flo1.ToString();

            Read();
        }
    }
}

// string -> int -> float -> string
/* 참고 자료

1.실수, 정수의 문자변환
int a = 3;
string str = a.ToString();

float b = 3.0f;
string str = b.ToString();

2.정수 -> 실수 변환 (int -> float)
int a = 3;
float b = (float)a;

3.실수 -> 정수 변환
float a = 3.0f;
int b = (int)a;

double c = 123.45;

int d = (int)c;

4.문자열 -> 실수, 정수 변환
string e = "123";
string f = "123.456";

int g = int.Parse(e);
float h = float.Parse(f);

또는

int g = Convert.Toint32(e);
float h = Convert.ToSingle(h);
*/