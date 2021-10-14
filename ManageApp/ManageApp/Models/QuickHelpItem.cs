using System;
using System.Collections.Generic;
using System.Text;

namespace ManageApp.Models
{
    public class QuickHelpItem
    {
        public QuickHelpItem(string image,string title)
        {
            Image = image;
            Title = title;
        }
        public string Image { get; }
        public string Title { get; }
    }
}
