using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OsuParsers.Beatmaps;
using OsuParsers.Decoders;

namespace WebSucker.Metronome
{
    class TimingBeatmapReader
    {
        string pathToOsu = @"D:\Games\osu!\songs"; // your path to osu songs
        public Beatmap currentBeatmap;
        public void Parse()
        {
            if (currentBeatmap == null)
            {
                currentBeatmap = BeatmapDecoder.Decode(Path.Combine(pathToOsu, Program.b.Menu.Bm.Path.Folder, Program.b.Menu.Bm.Path.File));
                return;
            }
            if (currentBeatmap.MetadataSection.Title != Program.b.Menu.Bm.Metadata.Title)
                currentBeatmap = BeatmapDecoder.Decode(Path.Combine(pathToOsu, Program.b.Menu.Bm.Path.Folder, Program.b.Menu.Bm.Path.File));
        }
    }
}
