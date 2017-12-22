using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Culture {
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("开始运行");
            //Console.OutputEncoding = Encoding.UTF8;
            BuildWebHost(args).Run();            
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
