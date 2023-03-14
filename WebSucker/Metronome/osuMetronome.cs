using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebSucker.Metronome
{
    class osuMetronome
    {
        List<OsuParsers.Beatmaps.Objects.TimingPoint> timings;
        SoundPlayer player;
        TimingBeatmapReader reader;
        bool stop;
        public void SetBPM(int _bpm, int beat)
        {
            BPM = _bpm;
            tickCount = 3;
             BEAT = beat;
        }
        int BPM, BEAT;
        int MillisecondsPerBeat
        {
            get => (int)(60000.0 / BPM);
        }
        int MillisecondsPerTick
        {
            get => MillisecondsPerBeat / BEAT;
        }
        long currentTimeMS = 0;
        int tickCount = 0;
        int globalTickCount = 0;


        public async Task Start(int bpm, int beat)
        {
            BPM = bpm;
            BEAT = beat;
            player = new SoundPlayer();
            reader = new TimingBeatmapReader();
            await UpdateInfo();
        }
        async Task UpdateInfo()
        {
            while (true)
            {
                //waiting for parse
                while (!Program._b_parsed)
                {
                    await Task.Delay(20);
                }
                if (Program.b.Menu.State != 2)
                {
                    stop = true;
                    while (Program.b.Menu.State != 2)
                    {
                        await Task.Delay(20);
                    }
                }

                long keys = (Program.b.Gameplay.Hits.The300);
                if (keys > 0)
                {
                    
                    reader.Parse();
                    timings = reader.currentBeatmap.TimingPoints.Where(n => !n.Inherited).OrderBy(n => Math.Abs(n.Offset - currentTimeMS)).ToList();
                    Console.WriteLine("wtf " + reader.currentBeatmap.TimingPoints.First().BeatLength);
                    

                    tickCount = 0;
                    Console.WriteLine("/bpm" + BPM + "/" + currentTimeMS / 2);

                    await PlayMetronome();


                }
                else
                {
                    stop = true;
                }
            }
        }
        async Task PlayMetronome()
        {
            bool _stop = false;
            while (!_stop)
            {
                if (stop) _stop = true;
                currentTimeMS += MillisecondsPerTick;
                if (tickCount % 16 == 0)
                {
                    Console.WriteLine("bpm" + BPM + "/" + currentTimeMS / 2);
                }

                if (timings.Count != 1)
                {
                    if (globalTickCount % (timings[1].Offset - timings[0].Offset) / MillisecondsPerTick == 0)
                    {
                        SetBPM(Convert.ToInt32(60000.0 / timings[0].BeatLength), 4);
                    }
                }
                else
                {
                    SetBPM(Convert.ToInt32(60000.0 / timings[0].BeatLength), 4);
                }
                tickCount++;

                if (tickCount % BEAT == 0)
                {
                    globalTickCount++;
                    player.PlaySound(100);
                    Console.Write("|" + globalTickCount + "|");
                }
                else
                {
                    player.PlaySound(10);
                    Console.Write(".");
                }
                await Task.Delay(MillisecondsPerTick);
            }
        }
    }
}