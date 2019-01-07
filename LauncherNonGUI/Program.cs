using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LauncherNonGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "BadRBLX 2012 Launcher";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("BADRBLX 2012 LAUNCHER (NOGUI)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Made by TypicalName and ScottBeebiWan");
            Console.WriteLine("input IP");
            string ipinput = Console.ReadLine();
            Console.WriteLine("input port");
            string portinput = Console.ReadLine();
            Console.WriteLine("input charapp");
            string charappinput = Console.ReadLine();
            Console.WriteLine("input username");
            string usernameinput = Console.ReadLine();
            Random rng = new Random();
            Process.Start("badrblx.exe", "-joinscripturl \"http://badrblx.scottbeebiwan.tk/scripes/litjoinscript.php?username=" + usernameinput + "&ip=" + ipinput + "&port=" + portinput + "&id=" + rng.Next(0, 291943).ToString() + "&charapp=" + charappinput + "\"");
        }
    }
}
