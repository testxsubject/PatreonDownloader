﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace PatreonDownloader
{
    public class GalleryEntry : ICloneable
    {
        public Int64 Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string PageUrl { get; set; }

        public string DownloadUrl { get; set; }

        public string Path { get; set; }

        public DateTime AddedOn { get; set; }

        public Gallery Gallery { get; set; }

        [NotMapped]
        public bool Parsed { get; set; }

        public object Clone()
        {
            return new GalleryEntry
            {
                AddedOn = AddedOn,
                Author = Author,
                Description = Description,
                DownloadUrl = DownloadUrl,
                Gallery = Gallery,
                Id = Id,
                Name = Name,
                PageUrl = PageUrl,
                Parsed = Parsed,
                Path = Path
            };
        }
    }
}
