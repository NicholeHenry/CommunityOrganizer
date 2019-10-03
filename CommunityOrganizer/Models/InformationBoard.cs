﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityOrganizer.Models
{
    public class InformationBoard : IModel
    {
        public int Id { get; set; }

        public string HeadLine { get; set; }

        public string HeadLineTwo { get; set; }

        public string HeadLineThree { get; set; }

        public string MessageBody { get; set; }

        public string MessageBodytwo { get; set; }

        public string MessageBodythree { get; set; }
    }
}
