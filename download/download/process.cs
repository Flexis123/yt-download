using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using IronPython.Hosting;
using System.IO;


namespace download
{
    class process
    {
        
        
        public static async Task download(string Url,string path)
        {
            await Task.Run(() =>
            {
                var engine = Python.CreateEngine();
                

                var script = @"C:\Users\user\Desktop\yt-download\download\download\down\download.py";
                var source = engine.CreateScriptSourceFromFile(script);

                //var argv = new List<string>();
                //argv.Add("");
                //argv.Add(Url);

                //engine.GetSysModule().SetVariable("argv",argv);
                

                var eIO = engine.Runtime.IO;
                var errors = new MemoryStream();
                eIO.SetErrorOutput(errors,Encoding.Default);

                var results = new MemoryStream();
                eIO.SetOutput(results, Encoding.Default);

                var scope = engine.CreateScope();
                scope.ImportModule("os");
                
                source.Execute(scope);

                string str(byte[] x) => Encoding.Default.GetString(x);

                Console.WriteLine("ERRORS:");
                Console.WriteLine(str(errors.ToArray()));
                Console.WriteLine();
                Console.WriteLine("Results:");
                Console.WriteLine(str(results.ToArray()));
            });
        }
    }
}
