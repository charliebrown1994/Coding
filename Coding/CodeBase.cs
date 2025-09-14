using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class CodeBase
    {
        public void Paramiter()
        {
            int number;
            number = 10;
            Console.WriteLine(number);

            // 변수 선언 + 변수 값 할당 + 변수 사용
            int i;
            i = 1234;
            Console.WriteLine(i); // 변수 값을 사용하는 것을 "변수 참조"라고 한다.
            // 출력 1234
            /*--------------------------------------------------*/
            // 변수 선언과 동시에 변수 값 할당
            int age = 20;
            Console.WriteLine("{0}", age);
            // 같은 자료형 변수 여러게 선언하기
            // int a, b, c; 콤마로 구분하여 같은 자료형 변수 여러개 선언 가능
            int number1, number2, number3;
            number1 = 1;
            number2 = 2;
            number3 = 3;
            Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
            // 출력 1, 2, 3
            // 변수 여러개 선언하고 동일한 값 할당
            int a, b, c;
            a = b = c = 10;
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            // 출력 10, 10, 10
            /*--------------------------------------------------*/
            // 상수 사용하기
            // 키워드 const를 사용하여 상수 선언, 상수로 선언한 변수는 값을 변경할 수 없고,
            // 반드시 선언과 동시에 값을 할당해야 한다, 이를 상수 또는 지역 상수 라고도 한다.
            const int MAX = 100;
            // MAX = 200; // 오류 발생
            // 상수 한줄 정의 "변하지 않는 변수, 읽기 전용 변수"
            Console.WriteLine("최대값 : {0}", MAX);
            // 출력 : 최대값 : 100
        }
    }
}
