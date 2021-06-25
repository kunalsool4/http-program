using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PracticeConsoleApp
{
    class Program
    {
        string url = "https://jsonplaceholder.typicode.com/todos";
        HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetJsonData();
        }
        private async Task GetJsonData()
        {
            string responese = await client.GetStringAsync(url);
            Console.WriteLine(responese);
            Console.ReadLine();
        }
    }
}
