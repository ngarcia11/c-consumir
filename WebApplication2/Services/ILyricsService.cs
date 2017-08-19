using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VP.ApiSample.Models;

namespace VP.ApiSample.Services
{
    public interface ILyricsService
    {
        Lyrics GetLyrics(Track track, string apiKey);
    }
}
