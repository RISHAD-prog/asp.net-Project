﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NoticeBoardDTO
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
  
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
