using System.Threading;
using static System.Console;

namespace RamenPickingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 3000; //현재 돈
            WriteLine($"라면을 사시겠습니까? 현재 소지금은 {money}원 입니다."); //대사 출력
            WriteLine("현재 남은 라면은 \n1.삼양라면\n2.진라면\n3.참께라면\n라면의 숫자를 입력해주세요 (라면의 가격은 1000원 입니다)");
            int ramenNumber = Read();

            if (ramenNumber == 49)  // 아스키 코드 49 == 1 50 == 2 51 == 3
            {
                WriteLine("삼양라면을 구매했습니다.");
                Thread.Sleep(500);
                WriteLine($"현재 소지금은 {money - 1000}원 입니다.");

            }
            else if (ramenNumber == 50)
            {
                WriteLine("진라면을 구매했습니다.");
                Thread.Sleep(500);
                WriteLine($"현재 소지금은 {money - 1000}원 입니다.");
            }
            else if (ramenNumber == 51)
            {
                WriteLine("참께라면을 구매했습니다.");
                Thread.Sleep(500);
                WriteLine($"현재 소지금은 {money - 1000}원 입니다.");
            }
        }
    }
}
