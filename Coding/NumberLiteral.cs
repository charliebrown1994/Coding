using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class NumberLiteral
    {
        public void Literal()
        {
            // 정수 리터럴
            Console.WriteLine("{0}", 1234); // 십진수
            Console.WriteLine("{0}", 0x1234); // 16진수
            int octalValue = Convert.ToInt32("1234", 8); // 8진수를 십진수로 변환
            Console.WriteLine("{0}", octalValue);

            //Console.ReadLine();
            // 정수 데이터 형식
            // 정수가 가질수 있는 최댓값과 최솟값 출력
            int min = -2147483647; // 정수형이 가질 수 있는 최솟값
            int max = 2147483647; // 정수형이 가질 수 있는 최댓값
            Console.WriteLine("int형 최소값 : {0}", min);
            Console.WriteLine("int형 최대값 : {0}", max);
            // 출력 : int형 최소값 : -2147483647
            //       int형 최대값 : 2147483647
            /*--------------------------------------------------*/
            // 부호있는 정수 데이터 형식 사용
            sbyte iSByte = 127;
            short iInt16 = 32767;
            int iInt32 = 2147483647;
            long iInt64 = 9223372036854775807;

            Console.WriteLine("8비트 sbyte : {0}", iSByte);
            Console.WriteLine("16비트 short : {0}", iInt16);
            Console.WriteLine("32비트 int : {0}", iInt32);
            Console.WriteLine("64비트 long : {0}", iInt64);
            // 이코드는 sbyte, short, int, long형이 가질 수 있는 최댓값을 변수에 할당하고 출력하는 코드입니다.
            /*--------------------------------------------------*/
            // 부호없는 정수 데이터 형식 사용
            byte iByte = 255;
            ushort iUInt16 = 65535;
            uint iUInt32 = 4294967295;
            ulong iUInt64 = 18446744073709551615;

            Console.WriteLine("8비트 byte : {0}", iByte);
            Console.WriteLine("16비트 ushort : {0}", iUInt16);
            Console.WriteLine("32비트 uint : {0}", iUInt32);
            Console.WriteLine("64비트 ulong : {0}", iUInt64);
            // 이코드는 byte, ushort, uint, ulong형이 가질 수 있는 최댓값을 변수에 할당하고 출력하는 코드입니다.
            // 부호가 있는 정수형 보다 2배 더 큰 값을 저장할 수 있습니다.
            /*--------------------------------------------------*/
            // * 최솟값과 최댓값은 MinValuer,MaxValue 속성을 사용하여 구할 수도 있습니다.
            Console.WriteLine("[32비트] int 최솟값", int.MinValue);
            Console.WriteLine("[32비트] int 최대값", int.MaxValue);
            // 출력 : [32비트] int 최솟값 -2147483648
            //       [32비트] int 최대값 2147483647
            /*--------------------------------------------------*/
            // 실수 데이터 형식
            // double 키워드로 실수 데이터 형식 선언 및 초기화
            double PI = 3.141592;
            Console.WriteLine("{0}", PI);
            // 출력 : 3.141592
            /*--------------------------------------------------*/
            // float 키워드로 실수 데이터 형식 선언 및 초기화
            float f = 99.99f; // 접미사 f 또는 F를 붙여야 한다.
            Console.WriteLine("{0}", f);
            // 출력 : 99.99
            /*--------------------------------------------------*/
            // decimal 키워드로 실수 데이터 형식 선언 및 초기화
            decimal d = 12.34m; // 접미사 m 또는 M을 붙여야 한다.
            Console.WriteLine("{0}", d);
            // 출력 : 12.34
            /*--------------------------------------------------*/
            // 숫자 향식의 리터럴 값에 접미사 붙이기
            float fe = 3.14f;
            double de = 3.14d;
            decimal me = 3.14m;
            Console.WriteLine("{0}, {1}, {2}", fe, de, me);
            // 출력 : 3.14, 3.14, 3.14
        }
    }
}
