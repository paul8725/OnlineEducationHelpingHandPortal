using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineEducationHelpingHandPortal.Model
{
    public class Education
    {
        //Message id
        public int Id { get; set; }

        //Mesage text
        public string Name { get; set; }

        //Message sender
        public string Description { get; set; }

        //Message time
        public DateTime time { get; set; }

    }
}
