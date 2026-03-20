using DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Media : Record
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string YoutubeId { get; set; }
        public int OwnerId { get; set; } = User.ConnectedUser != null ? User.ConnectedUser.Id : 1;
        public bool isShared { get; set; } = true;
        public DateTime PublishDate { get; set; } = DateTime.Now;

        [JsonIgnore]
        public User Owner
        {
            get
            {
                return DB.Users.Get(OwnerId);
            }
        }
    }
    }