using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Models
{
    public enum MenuItemType
    {
        Browse,
        Message,
        Notification,
        Photo,
        Video,
        Location,
        About,
        Search
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
