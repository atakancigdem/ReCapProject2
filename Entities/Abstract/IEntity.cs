﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
    }
}
