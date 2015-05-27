using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndEvents.Crosscutting.Domain
{
    public class Event
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime AlertOn { get; set; }

        public DateTime Createdon { get; set; }

        public Account Creator { get; set; }

        public int CreatorId { get; set; }
    }
}
