using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    internal class CharacterDemo
    {
        public void CharDemo()
        {
            // 문자 데이터 형식 char
            // 문자형 데이터 형식 변수 선억
            char grade = 'A';
            char kor = '가';
            Console.WriteLine(grade);
            Console.WriteLine(kor);
            // 출력 : A
            //       가
            /*--------------------------------------------------*/
            // 문자열 데이터 형시 변수 선언 string
            string name = "이승율";
            Console.WriteLine(name);
            Console.WriteLine("안녕하세요, {0}입니다!", name);
            // 출력 : 이승율
            //       안녕하세요, 이승율입니다!
            /*--------------------------------------------------*/
            // @ 기호로 여러 줄 문자열 사용
            string multiLines = @"안녕하세요,
                                반갑습니다.";
            Console.WriteLine(multiLines);
            /*--------------------------------------------------*/
            // 문자열 보간법
            //string message = "Hello!";
            // $"{message}";
            // 출력 : Hello!
            int number = 3;
            string result = "홀수";
            Console.WriteLine($"{number}은(는) {result}입니다");
            // 출력 : 3은(는) 홀수입니다
            string msg = string.Format("{0}, {1}", "홍길동", "안녕하세요");
            Console.WriteLine(msg);
            // 출력 : 홍길동, 안녕하세요
            // 문자열 보간법 연습
            string testName = "C#";
            string testVersion = "14";
            Console.WriteLine("{0} {1}", testName, testVersion);
            string testResult = string.Format("{0} {1}", testName, testVersion);
            Console.WriteLine(testResult);
            Console.WriteLine($"{testName} {testVersion}");
            // 출력 : C# 14 (다 같은 결과)
            /*--------------------------------------------------*/
            // 논리 데이터 형식 bool
            // true(참), false(거짓) 두 가지 값만 가질 수 있는 데이터 형식
            bool bln = true;
            Console.WriteLine(bln);
            bool isFalse = false;
            Console.WriteLine(isFalse);
            // 출력 : True
            //       False
            /*--------------------------------------------------*/
            // 변하지 않는 값 상수사용 하기
            const double PI = 3.14;
            const string SITE_NAME = "닷넷코리아";
            Console.WriteLine($"{PI}, {SITE_NAME}");
            // 출력 : 3.14, 닷넷코리아
            /*--------------------------------------------------*/
            // 닷넷 데이터 형식 사용
            Char c = 'A'; // char와 동일
            String s = "안녕하세요"; // string과 동일
            Boolean b = true; // bool과 동일
            Console.WriteLine("{0}\n{1}\n{2}", c, s, b);
            // 출력 : A
            //       안녕하세요
            //       True
            /*--------------------------------------------------*/
            // 래퍼 형식
            int number1 = 1234; // int 키워드 기본 형식
            Int32 number2 = 1234; // Int32 래퍼 형식, 닷넷 형식
            Console.WriteLine($"{number1}, {number2}");
            // 출력 : 1234, 1234
            string str1 = "안녕";
            String str2 = "안녕";
            Console.WriteLine($"{str1}, {str2}");
            // 출력 : 안녕, 안녕
            /*--------------------------------------------------*/
            // 날짜 형식
            DateTime date = DateTime.Now;
            Console.WriteLine(date);
            // 출력 : 2024-06-20 오후 2:34:56 (출력되는 날짜와 시간은 실행하는 시점에 따라 다름)
            Console.WriteLine($"{date.Year}-{date.Month}-{date.Day}");
            // 출력 : 2024-6-20 (출력되는 날짜는 실행하는 시점에 따라 다름)
            Console.WriteLine($"{date.Hour}:{date.Minute}:{date.Second}");
            // 출력 : 14:34:56 (출력되는 시간은 실행하는 시점에 따라 다름)
        }
    }
}
