﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core
{
    public abstract class BaseEntity<T> 
    {
        public T Id { get; set; }
    }
}