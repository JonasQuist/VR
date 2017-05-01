using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;


namespace VR.Models
{
    public class VideoModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string ImagePath { get; set; }
        public Image Thumbnail { get; set; }

    }
}