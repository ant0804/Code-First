﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Name { get; set; }

        [StringLength(500,MinimumLength = 10)]
        public string Owner { get; set; }

        public bool IsResort { get; set; }

        public int? DestinationId { get; set; }
        [Required]
        public Destination Destination { get; set; }


    }
}
