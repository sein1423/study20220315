using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace study20220315
{
    public class Calc
    {
        public int a, b;


        public void add()
        {
            WriteLine($"{a} + {b} = {a + b}");
        }
        public void min()
        {
            WriteLine($"{a} - {b} = {a - b}");
        }

        public void mul()
        {
            WriteLine($"{a} * {b} = {a * b}");
        }
//
        public void nan()
        {
            if (b == 0) 
            {

                WriteLine("0으로는 나눌 수 없습니다 ");
                return;
            }
            WriteLine($"{a} / {b} = {a / b}");
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            #region 삼항연산자 연습
            //WriteLine("정수를 하나 입력하시오");
            //string key = ReadLine();
            //int a;
            //a = int.Parse(key);

            //int b;

            //b = a > 5 ? 1 : 0;

            //WriteLine($"{b}입니다");
            #endregion

            #region 오버라이딩
            //string key;

            //int a, b;
            //float c, d;

            //Write("정수를 두개 입력하시오 : ");
            //key = ReadLine();
            //a = int.Parse(key);
            //key = ReadLine();
            //b = int.Parse(key);

            //Write("실수를 두개 입력하시오 : ");
            //key = ReadLine();
            //c = float.Parse(key);
            //key = ReadLine();
            //d = float.Parse(key);

            //int res = add(a, b);
            //float res2 = add(c, d);

            //WriteLine($"정수 더하기 : {res} , 실수 더하기 : {res2}");

            #endregion

            Calc cal = new Calc();
            string key;

            int a, b;
            float c, d;

            Write("정수를 두개 입력하시오 : ");
            key = ReadLine();
            a = int.Parse(key);
            key = ReadLine();
            b = int.Parse(key);

            cal.a = a;
            cal.b = b;
            int i;
            do
            {
                Write("정수를 입력하시오(1:+ , 2:- , 3:* , 4:/) : ");
                key = ReadLine();
                i = 0;
                i = int.Parse(key);

                switch (i)
                {
                    case 1:
                        cal.add();
                        break;
                    case 2:
                        cal.min();
                        break;
                    case 3:
                        cal.mul();
                        break;
                    case 4:
                        cal.nan();
                        break;
                    default:
                        WriteLine("다시 입력하시오");
                        break;
                }
//커밋
            } while (i<1||i>4);
            
        }
    }
}
