using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VP.ApiSample.Models;

namespace VP.ApiSample.Services
{
    public interface ITrackService
    {
        List<Track> GetTracks(string searchQuery, int limit, string apiKey);
    }
}
