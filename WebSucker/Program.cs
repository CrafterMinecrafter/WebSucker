using System;
using System.IO;
using System.Threading.Tasks;
using GOsumemory;
using Newtonsoft.Json;
using WebSocketSharp;
using OsuParsers.Beatmaps;
using WebSucker.Metronome;

namespace WebSucker
{
    class Program
    {

        static osuMetronome metronome = new osuMetronome();
        static async Task Main(string[] args)
        {
            await Start();

            await metronome.Start(120, 4);

            Console.ReadKey(true);
        }

        public static bool _b_parsed;
        public static Root b = null;

        static void UpdateGosuMemory(string json)
        {

            b = JsonConvert.DeserializeObject<Root>(json);
            if (b.Gameplay != null) _b_parsed = true;

            //Console.WriteLine(Path.Combine(b.Settings.Folders.Songs, b.Menu.Bm.Path.File));
        }



        public static async Task Start()
        {
            using (WebSocket ws = new WebSocket("ws://127.0.0.1:24050/ws"))
            {
                ws.OnMessage += (sender, e) =>
                {
                    //Console.WriteLine("parsing");
                    UpdateGosuMemory(e.Data);
                };

                ws.OnOpen += (sender, e) =>
                {
                    Console.WriteLine(e.ToString());
                };
                ws.OnClose += async (sender, e) =>
                {
                    Console.WriteLine("cls Try to recon...");
                    await Task.Delay(5000);
                    ws.Connect();
                };

                ws.Connect();
                ws.Send("{\"m\":\"beatmap\",\"i\":0}");


                while (ws.ReadyState != WebSocketState.Open)
                {
                    await Task.Delay(30);
                }
            }

        }
    }
}