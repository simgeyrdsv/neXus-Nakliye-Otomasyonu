﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace traveltrip.Models.sınıflar
{
    public class İletisim
    {
        [Key]

        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Mesaj { get; set; }


    }
}