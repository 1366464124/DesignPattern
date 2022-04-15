using System;

namespace DesignPattern.General
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            string? s = await DownloadStringWithTimeout("https://www.google.com");
            Console.WriteLine(s??"timeout");
        }

        static async Task<string?> DownloadStringWithTimeout(string uri)
        {
            using (var client = new HttpClient())
            {
                var downloadTask = client.GetStringAsync(uri);
                var timeoutTask = Task.Delay(3000);

                var completedTask = await Task.WhenAny(downloadTask, timeoutTask);
                if (completedTask == timeoutTask) return null;
                return await downloadTask;
            }
        }
    }
}