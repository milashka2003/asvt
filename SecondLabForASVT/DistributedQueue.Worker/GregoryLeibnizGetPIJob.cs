using System;
using System.Threading;
using System.Threading.Tasks;

namespace DistributedQueue.Common
{
    internal class GregoryLeibnizGetPIJob : IComputePiJob
    {
        public Task ComputePyAsync(string name, int iterrations, CancellationToken token)
        {

            var startTime = DateTime.Now;

            var iterrationsToCheck = 1000000;
            var iterrationCurrent = 0;
            string[] strings = {
                    "Pizza",
                    "Sushi",
                    "Tacos",
                    "Pasta",
                    "Burger",
                    "Caesar Salad",
                    "Chicken Rice",
                    "Shish Kebab",
                    "Falafel",
                    "Kebab"
                };
            for (int i = 0; i < iterrations; i++)
            {
                Console.WriteLine($"{DateTime.Now}: Compute task: {name} He is like {strings[i%10]}");
                Thread.Sleep(1000);
            }


            Console.WriteLine($"Nane potoka: {name}, Iterrations: {iterrations}");

            return Task.CompletedTask;
        }
    }
}
