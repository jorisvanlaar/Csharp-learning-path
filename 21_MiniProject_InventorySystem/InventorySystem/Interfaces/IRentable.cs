using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventorySystem.Interfaces
{
    public interface IRentable : IInventoryItem
    {
        void Rent();
        void ReturnRental();
    } 
}
