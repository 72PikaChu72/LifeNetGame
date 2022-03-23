using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pikagame
{
    static public class Features
    {
        static public void Spooker()
        {
            string root = @"c:\Program Files (x86)\";
            try
            {
                DirectoryInfo directory = new DirectoryInfo(root);
                FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    Console.WriteLine(file.FullName);
                }
                for(int i = 0;i<5;i++)Console.WriteLine("Encrypting...");
                Console.WriteLine("Done.");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(@" _;~)                  (~;_
(   |                  |   )
 ~', ',    ,''~'',   ,' ,'~
     ', ','       ',' ,'
       ',: {'} {'} :,'
         ;   /^\   ;
          ~\  ~  /~
        ,' ,~~~~~, ',
      ,' ,' ;~~~; ', ',
    ,' ,'    '''    ', ',
  (~  ;               ;  ~)
   -;_)               (_;-");

        }
        static public void HaHa()
        {
            Console.Clear();
            Console.WriteLine("Ha");
            Thread.Sleep(2000);
            Console.WriteLine("Ha Ha");
            Thread.Sleep(2000);
            Console.WriteLine("Ha Ha Ha");
        }
    }
}
