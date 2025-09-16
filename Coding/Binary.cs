using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Coding
{
    internal class Binary
    {
        public void BinaryDemo()
        {
            // 이진수 다루기
            Convert.ToString(10, 2).PadLeft(8, '0');
            // PadLeft() 메서드를 사용하여 8칸을 기준으로 이진수 문자열릏 출력하고 앞부분을 0으로 채움
            // 정수를 이진수 문자열로 표현
            byte x = 10; // 0000 1010
            Console.WriteLine($"십진수 : {x} -> 이진수 : {Convert.ToString(x, 2).PadLeft(8, '0')}");
            // 출력 : 십진수 : 10 -> 이진수 : 00001010
            /*----------------------------*/
            // 진법 변환 (십진수를 이진수로 이진수를 십진수로)
            Console.WriteLine($"십진수 10을 이진수로 변경 : {Convert.ToString(10, 2)}");
            Console.WriteLine($"이진수 1010을 십진수로 변경 : {Convert.ToInt32("1010", 2)}");
            // 출력 : 십진수 10을 이진수로 변경 : 1010
            // 출력 : 이진수 1010을 십진수로 변경 : 10
            /*----------------------------*/
            // 이진수 리터널
            byte b1 = 0b0010; // 이진수 0010 -> 십진수 2
            byte b2 = 0B1100; // 이진수 1100 -> 십진수 12
            Console.WriteLine($"십진수 {b1}");
            Console.WriteLine($"십진수 {b2}");
            // 출력 : 십진수 2
            // 출력 : 십진수 12
            /*----------------------------*/
            // 언더스코어(_)로 숫자 구분하기
            // 플로그램 소스에서는 언더스코어로 콤마를 대체해 세자리수를 구분합니다
            int bin = 0b0001_0001; // 17
            Console.WriteLine($"십진수 {bin}");
            // 출력 : 십진수 17
            int dec = 1_000_000; // 1,000,000
            Console.WriteLine($"십진수 {dec}");
            // 출력 : 십진수 1000000
            int hex = 0xA0_B0_C0; // 0xA0B0C0
            Console.WriteLine($"십진수 {hex}");
            // 출력 : 십진수 10570656
            /*----------------------------*/
            // var 키워드로 암시적으로 형식화된 로컬 변수 만들기
            int number = 1234; // 명시적으로 형식화된 로컬 변수
            var number1 = 1234; // 암시적으로 형식화된 로컬 변수
            // var 키워드로 변수 선언과 초기화 
            var name = "C#"; // string 형식으로 변환함
            Console.WriteLine(name);
            // 출력 : C#
            var version = 14; // double 형식으로 변환함
            Console.WriteLine("{0:0.0}", version);
            // 출력 : 14.0
            var number2 = 1234; // int 형식으로 변환함
            Console.WriteLine(number2.GetType());
            // 출력 : System.Int32
            var message = "안녕하세요"; // string 형식으로 변환함
            Console.WriteLine(message.GetType());
            // 출력 : System.String
            /*--------------------*/
            // 입력 값을 var로 선언하고 변수로 받기
            var s = Console.ReadLine(); // 문자열 입력 받기
            var c = Convert.ToChar(Console.Read()); // 문자 하나 입력받기
            Console.WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");
            // 출력 : Hello
            //        C
            // Hello : System.String, C : System.Char
            /*----------------------------------*/
            Console.WriteLine("아무키나 누르세요");
            ConsoleKeyInfo cki = Console.ReadKey(true); // 키보드 기 값 입력
            Console.WriteLine("{0}", cki.Key); // 키
            Console.WriteLine("{0}", cki.KeyChar);// 유니코드
            Console.WriteLine("{0}", cki.Modifiers); //Ctrl, Shift, Alt 조합
            if (cki.Key == ConsoleKey.Q)
            {
                Console.WriteLine("Q를 입력하셨군요...");
            }
            /*------------------------------------------*/
            // 변수의 기본ㄱㅄ을 default 키워드로 설정하기
            int i = default;
            double d = default;
            char cr = default;
            string str = default;
            Console.WriteLine($"{i}, {d}, {cr}, {str}");
            // 출력 : 0, 0, \0,  
            Console.WriteLine($"{i}, {d}, {cr == Char.MinValue}, {str == null}");
            // 출력 : 0, 0, True, True
            int intDefault = default(int);
            Console.WriteLine(intDefault);
            // 출력 : 0
            bool boolDefault = default(bool);
            Console.WriteLine(boolDefault);
            // 출력 : false
            string strDefault = default(string);
            Console.WriteLine(strDefault);
            // 출력 : null
            StringBuilder sbDefault = default(StringBuilder);
            Console.WriteLine(sbDefault);
            // 출력 : null
            // 튜플 리터럴
            var t = (100, 200);
            Console.WriteLine($"{t.Item1}, {t.Item2}");
            // 출력 : 100, 200
            var (x, y) = (300, 400);
            Console.WriteLine($"{x}{y}");
            // 출력 : 300400
        }
    }
}
