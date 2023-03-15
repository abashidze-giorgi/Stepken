using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IItemPanel
    {
        public void AddWeaponToStorePanel();
        public void SelectWeaponFromStorePanel();
        public void DeselectWeaponFromUnit();
    }
}
