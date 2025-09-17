using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class Operator
    {
        public void DoOperator()
        {
            // 연산자와 피연산자
            int num = 1000;
            int number = num + 1234;
            Console.WriteLine(number);
            // 출력 : 2234;
            // + 기호는 연산자, num, number 는 피연산자
            /*------------------------------------------*/
            // 신과 문
            // 3 + 5 = 8 식입니다
            // 3 - 5 = -2 식입니다
            Console.WriteLine(3 * 5);
            // 15
            Console.WriteLine(3 / 5 );
            // 0
            /*-----------------------------------*/
            // 단항연산자
            int value = 0;
            value = 8;
            value = +value;
            Console.WriteLine(value);
            // 출력 : 8
            value = -8;
            value = +value;
            Console.WriteLine(value);
            // 출력 : -8
            value = -8;
            value = -value;
            Console.WriteLine(value);
            // 출력 : 8
            /*-------------------------------------*/
            // 변환 연산자
            int number1 = (int)3.14;
            Console.WriteLine(number1);
            // 출력 : 3
            long number2 = (long)3.141592;
            Console.WriteLine(number2);
            // 출력 : 3
            double number3 = (double)3.141592;
            Console.WriteLine(number3);
            // 출력 : 3.141592
            /*-----------------------------------------*/
            // 산수연산자
            // C#은 간단한 산술 연산을 수행하는 사칙 연산자 (+, -, *, /, %)를 제공합니다
            // 3 + 5
            // 8
            // 3 - 5
            // -2
            // 3 * 5 
            // 15
            // 10 / 2 
            // 2
            // 3 % 5
            // 3
            // 실수 연산은 미세한 오차가 발생할 수 있습니다
            // 3.141592 - 3.0 
            // 0.14159200000000016
            // 그래서 decimal을 사용합니다
            decimal PI = 3.14159M;
            Console.WriteLine(PI - 3.0M);
            // 출력 : 0.14159
            // 더하기 연산자
            int i = 10;
            int j = 20;
            int k = i + j;
            Console.WriteLine(k);
            // 출력 : 30
            // 빼기연산자
            decimal I = 3.14M;
            decimal J = 3.14M;
            decimal K = I - J;
            Console.WriteLine(K);
            // 출력 : 0.00
            // 곱하기 연산자
            long g = 100;
            long h = 200;
            long m = g * h;
            Console.WriteLine(m);
            // 출력 : 20000
        }
    }
}
