﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Application.Common
{
    public class MessageDto
    {
        
        [Required]
        public string MessageContent { get; set; }
    }
}
