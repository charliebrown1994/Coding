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
        }
    }
}
