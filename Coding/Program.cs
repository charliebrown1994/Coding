namespace Coding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 출력문
            System.Console.WriteLine("명령 프롬프트에 출력할 내용");
            Console.WriteLine("명령 프롬프트에 출력할 내용");
            // 같은 출력 결과
            /*--------------------------------------------------*/
            // WriteLien과 Write의 출력 후 줄마꿈 차이
            Console.Write("줄 바꿈 없음");
            Console.WriteLine("줄 바꿈 포함");
            // 출력 : 줄 바꿈 없음줄 바꿈 포함
            /*--------------------------------------------------*/
            // 줄 바꿈 기호 : \n
            Console.WriteLine("줄\n바꿈");
            // 출력 : 줄
            //       바꿈
            /*------------------------------------------------*/
            // 주석문 (코드 설명문)
            Console.WriteLine("주석문"); // 실행에 영행을  주지 않는 코드 설명문
            // 출력 : 주석문 (주석문은 출력되지 않음)
            // 한 줄 주석 "//", 여러 줄 주석 "/* */"
            /*
             * Console.WriteLine("현재 구문은 실행되지 않습니다");
             * Console.WriteLine("현재 구문은 실행되지 않습니다");
             */
            /*--------------------------------------------------*/
            // 들여쓰기
            // Tab키(4칸) 또는 Space바(2칸)를 이용하여 코드의 계층 구조를 알기 쉽게 표현
            /*--------------------------------------------------*/
            // 공백 처리
            // 공백은 기본적으로 무시됨
            Console.WriteLine("C#");
            Console. WriteLine ( "C#" ) ;
            Console.
                WriteLine(
                      "C#")
                ;
            // 모두 동일한 출력 결과 : C#
            /*--------------------------------------------------*/
            // 이스케이프 문자
            // \n : 줄 바꿈, \t : 들여쓰기, \r : 캐리지 리턴(줄 바꿈 + 커서를 맨 앞으로 이동), \" : 큰 따옴표, \' : 작은 따옴표
            // 큰 따움표, 작은 따움표
            Console.WriteLine("[1]\"난 큰 따움표");
            Console.WriteLine("[1]\'난 작은 따움표");
            // 출력 : [1]"난 큰 따움표
            //       [1]'난 작은 따움표
            /*--------------------------------------------------*/
            // 자리 표시자
            Console.WriteLine("{0}", "Hello, C#");
            Console.WriteLine("{0}, {0}", "Hello, C#");
            Console.WriteLine("{0}, {1}", "Hello", "C#");
            Console.WriteLine("{1}, {0}", "C#", "Hello");
        }
    }
}
