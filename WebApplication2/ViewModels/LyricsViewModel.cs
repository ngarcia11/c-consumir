﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VP.ApiSample.Models;

namespace VP.ApiSample.ViewModels
{
    public class LyricsViewModel
    {
        public Track SelectedTrack { get; set; }
        public Lyrics Lyrics { get; set; }
        public bool HasToken { get; set; }
        public List<SelectListItem> Playlists { get; set; }
        public bool TrackAdded { get; set; }
    }
}
