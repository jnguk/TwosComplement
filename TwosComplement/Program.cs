using System;

namespace TwosComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2진수 입력시 0b 접두사 필요; 자리수 구분자 _ 자동으로 무시");
            while (true)
            {
                var temp = Console.ReadLine().Replace("_", "");

                try
                {
                    temp = Convert.ToString(Convert.ToSByte(temp), 2);
                }
                catch
                {
                    Console.WriteLine("숫자가 아니거나 너무 큽니다. 다시 시도하세요.");
                    continue;
                }

                TwosComplement.Calc(Convert.ToSByte(temp.Length >= 8 ? temp[8..] : temp.PadLeft(8, '0'), 2));
            }
        }
    }
}
