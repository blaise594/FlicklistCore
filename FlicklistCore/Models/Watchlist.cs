using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlicklistCore.Models
{
    public class Watchlist
    {
        public int Id { get; set; }
        public string Movie { get; set; }
    }
    public enum Status
    {
        Unwatched,
        Watched
    }
}
