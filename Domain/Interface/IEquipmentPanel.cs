using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IEquipmentPanel
    {
        public void AddWeaponToEquipmentPanel();
        public void SelectWeaponFromEquipmentPanel();
        public void DeselectWeaponFromUnit();
    }
}
