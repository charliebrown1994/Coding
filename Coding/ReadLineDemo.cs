using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class ReadLineDemo
    {
        public void ReadLine()
        {
            //Console.WriteLine(Console.ReadLine());
            //// 사용자가 입력한 내용을 그대로 출력
            //// 사용자가 입력한 이름을 입력받아 출력
            //Console.Write("이름을 입력하세요 : ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"안녕하세요 {name}님");
            //// 출력 : 이름을 입력하세요 : 홍길동
            ////       안녕하세요 홍길동님
            //// 문자 하나만 입력받는 Read() 메서드 사용
            //int x = Console.Read(); // 문자 하나를 입력받아 해당 문자의 아스키 코드 값을 반환
            //Console.WriteLine(x); // 입력한 문자의 아스키 코드 값 출력
            //Console.WriteLine(Convert.ToChar(x)); // 아스키 코드 값을 문자로 변환하여 출력
            /*--------------------------------------------------*/
            // 형식변환
            // 같은 자료형은 같은 값을 할당해도 괜찮음 
            // 암시적 형변환은 안전하고 데이터 손실이 없음 
            // 예시 :
            int number1 = 1234; // int형 변수 number1에 123 할당
            long number2 = number1; // int형 변수 number1을 long형 변수 number2에 암시적 형변환하여 할당
            Console.WriteLine(number2); // 출력 : 1234
            // 명시적 형변환은 데이터 손실이 있을 수 있음
            // 예시 :
            long number3 = 1234; // long형 변수 number3에 1234 할당
            int number4 = (int)number3; // long형 변수 number3을 int형 변수 number4에 명시적 형변환하여 할당
            Console.WriteLine(number4); // 출력 : 1234
            /*--------------------------------------------------*/
            // long을 int로 명시적 형변환
            long l = long.MaxValue; // long형 변수 l에 long형의 최대값 할당
            Console.WriteLine($"l의 값은 {l}");
            int i = (int)l; // long형 변수 l을 int형 변수 i에 명시적 형변환하여 할당
            Console.WriteLine($"i의 값은 {i}");
            // 출력 : l의 값은 9223372036854775807
            //       i의 값은 -1
            // int를 byte로 명시적 형변환
            int x = 255;
            byte y = (byte)x; // int형 변수 x를 byte형 변수 y에 명시적 형변환하여 할당
            Console.WriteLine($"{x} -> {y}");
            // 출력 : 255->255
            int a = 1234;
            string b = Convert.ToString(a);
            /*--------------------------------------------------*/
            // Convort 클래스로 형식 변환
            double d = 12.34;
            int n = 1234;

            d = n; // 큰 그릇에 작은 그릇의 값을 저장
            Console.WriteLine("암시적 형식 변환 = " + d);
            d = 12.34;
            n = (int)d; // 작은 그릇에 큰 그릇의 값을 저장
            Console.WriteLine("명시적 형식 변환 = " + n);

            string s = "";
            s = Convert.ToString(d);
            Console.WriteLine("형식 변환 = " + s);
            // 출력 : 암시적 형식 변환 = 1234
            //       명시적 형식 변환 = 12
            //       형식 변환 = 12.34
            /*--------------------------------------------------*/
            // GetType() 메서드로 데이터 형식 확인
            int num = 1234;
            string str = "안녕하세요";
            char c ='A';
            double db = 3.14;
            object o = new object(); // object형 변수 o에 새로운 object 객체 할당

            Console.WriteLine(num.GetType());
            Console.WriteLine(str.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(db.GetType());
            Console.WriteLine(o.GetType());
            // 출력 : System.Int32
            //       System.String
            //       System.Char
            //       System.Double
            //       System.Object
            /*--------------------------------------------------*/
            // 입력 받은 ㅇ문자열을 정수로 변환해서 출력
            Console.Write("정수를 입력하세요 : ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input); // 문자열을 정수로 변환
            Console.WriteLine($"{number} - {number.GetType()}");
            // 출력 : 정수를 입력하세요 : 1234
            //       1234 - System.Int32
            /*--------------------------------------------------*/
            // 실수를 문자열로 입력받아서 실수로 변환
            Console.Write("실수를 입력하세요");
            string inout2 = Console.ReadLine();
            double PI = Convert.ToDouble(inout2); // 문자열을 실수로 변환
            Console.WriteLine(PI);
            // 출력 : 실수를 입력하세요3.14
            //       3.14
            /*--------------------------------------------------*/
            // 문자열을 char형으로 변환
            Console.Write("문자를 입력하세요 : ");
            string input3 = Console.ReadLine();
            char ch = Convert.ToChar(input3); // 문자열을 char형으로 변환
            Console.WriteLine(ch);
            // 출력 : 문자를 입력하세요 : A
            //       A
        }
    }
}
