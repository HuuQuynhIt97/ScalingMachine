using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SingnalrClient
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var _connection = new HubConnectionBuilder()
            .WithUrl("http://10.4.5.132:11111/scalingHub")
           .Build();

            _connection.On<string, string, string>("Welcom", (scalingMachineID, message, unit) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                string newMessage = $"#### ### Welcom Big Scaling Machine Data: {scalingMachineID}: {message}: {unit}";
                Console.WriteLine(newMessage);
            });
            _connection.On<string, string>("Welcom", (scalingMachineID, message) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string newMessage = $"#### ### Hello! {scalingMachineID}: {message}";
                Console.WriteLine(newMessage);
            });

            await _connection.StartAsync();
            //await _connection.InvokeAsync("JoinHub", 2);
            while (true)
            {

                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "1600", "g");

                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "30.669", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "80", "g");

                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "37.917", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "770", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "1680", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "490", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "1", "2800", "g");
                //await Task.Delay(1000);
                //await _connection.InvokeAsync("Welcom", "2", "1.6", "k");


            }
        }

        
    }
}
