using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program     
    {
        class sysinfo
        {
            public string Win, Net, Cpu;             
            public string hostname, username;
            public sysinfo()
            {
                Net = Environment.Version.ToString();                
                Win = Environment.OSVersion.ToString();                 
                Cpu = Environment.ProcessorCount.ToString();                 
                hostname = Environment.MachineName.ToString();                 
                username = Environment.UserName.ToString();
            }
        }
        static void Main(string[] args)
        {             
            string P;             
            sysinfo F = new sysinfo();
            if (args.Length > 0) P = args[0];             
            else P = "null";
            switch (P) 
            {                 
                case "cpu": Console.WriteLine("CPU count: {0}", F.Cpu);                 
                    break;                 
                case "win": Console.WriteLine("Windows Version: {0}", F.Win);                 
                    break;                 
                case "net": Console.WriteLine(".NET Version: {0}", F.Net);                 
                    break;                 
                case "host": Console.WriteLine("Hostname: {0}", F.hostname);                 
                    break;                 
                case "user": Console.WriteLine("Username: {0}", F.username);                 
                    break;                 
                default: Console.WriteLine("Usage: sysinfo <cpu|win|net|host|user>");                 
                    break;
            }
        }
    }
}