﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DevBetterWeb.Web.Pages.ArchivedVideos
{
    public class ArchiveVideoDTO
    {
        public int Id { get; set; } // TODO: remove for create
        [Required]
        public string Title { get; set; }
        [DisplayName("Show Notes")]
        public string ShowNotes { get; set; }

        [DisplayName("Date Created")]
        public DateTimeOffset DateCreated { get; set; }

        [DisplayName("Video URL")]
        public string VideoUrl { get; set; }
    }
}