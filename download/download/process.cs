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

                var script = @"C:\Users\user\source\repos\download\download\down\download.py";
                var source = engine.CreateScriptSourceFromFile(script);

                var eIO = engine.Runtime.IO;
                var errors = new MemoryStream();
                eIO.SetErrorOutput(errors,Encoding.Default);

                var results = new MemoryStream();
                eIO.SetOutput(results, Encoding.Default);

                var scope = engine.CreateScope();
                source.Execute(scope);

                

            });
        }
    }
}
