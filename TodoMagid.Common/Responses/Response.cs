﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TodoMagid.Common.Responses
{
   public class Response
    {
        public bool IsSucces { get; set; }
        public string Message { get; set; }

        public object Result { get; set; }
    }
}
