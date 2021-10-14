using System;
using System.Collections.Generic;
using System.Text;

namespace ManageApp.Models
{
    public class NewMusicItem
    {
        public NewMusicItem(string image, string title,string description, int minute)
        {
            Image = image;
            Title = title;
            Description = description;
            Minute = minute;
        }
        public string Image { get; }
        public string Title { get; }
        public string Description { get; }
        public int Minute { get; }
    }
}
