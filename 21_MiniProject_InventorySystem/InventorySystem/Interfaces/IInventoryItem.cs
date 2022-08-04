﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventorySystem.Interfaces
{
    public interface IInventoryItem
    {
        string ProductName{ get; set; }
        int QuantityInStock { get; set; }
    } 
}
