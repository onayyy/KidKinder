﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKinder.Entites
{
	public class BookASeat
	{
        public int BookASeatId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public int ClassRoomId { get; set; }

        public virtual ClassRoom ClassRoom { get; set; }
    }
}