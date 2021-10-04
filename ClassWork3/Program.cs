using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3
{
    class Program
    {
        static void Main()

        {
            char ch = 'z';
            Console.WriteLine(ch);

            ch = (char)0x42F;
            Console.WriteLine(ch);

            Console.WriteLine(char.ToLower(ch));
            Console.WriteLine(char.IsLower(ch));

            string str = "";
            str = string.Empty;
            str = "Hello, World";

            ch = str[7];
            Console.WriteLine(ch);
            //ch = str[15;
            //str[7] = 'W';

            Console.WriteLine(str.Length);
            Console.WriteLine(str.IndexOf("World"));
            Console.WriteLine(str.IndexOf("o"));
            Console.WriteLine(str.LastIndexOf("o"));

            Console.WriteLine(str.ToLower());
            Console.WriteLine(str);

            Console.WriteLine(str.Substring(8, 2));
            Console.WriteLine(str.Substring(7));

            //string result = str.Substring(4, 1).ToUpper()
            //    + str.Substring(0, 1).ToLower()
            //    + str.Substring(5, 2)
            //    + str.Substring(2, 1).ToUpper()
            //    + str.Substring(8, 2)
            //    + str.Substring(11, 2);
            //Console.WriteLine(result);

            //result = ""
            //    + char.ToUpper(str[4])
            //    + char.ToLower(str[0])
            //    + str.Substring(5, 2)
            //    + char.ToUpper(str[2])
            //    + str.Substring(8, 2)
            //    + str.Substring(11, 2);
            //Console.WriteLine(result);

            str = "Фильм \"Криминальное чтиво\"";
            Console.WriteLine(str);

            str = @"D:\Videos\видосы";
            Console.WriteLine(str);

            str = @"Фильм ""Криминальное чтиво""";
            Console.WriteLine(str);

            Console.WriteLine("Число \"пи\" примерно равно {0:F5}", Math.PI);

            var moment = DateTime.Now;
            Console.WriteLine("Сейчас {0:HH:mm:ss.f dd.MM.yy}", moment);
            Console.WriteLine($"Сейчас {moment:HH:mm:ss.f dd.MM.yy}");

            Console.ReadKey();

        }
    }
}
