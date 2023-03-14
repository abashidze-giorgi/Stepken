using Domain.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stepken.UserController
{
    public partial class UCEquipment : UserControl, IEquipmentPanel
    {
        public UCEquipment()
        {
            InitializeComponent();
        }

        public void AddWeaponToEquipmentPanel()
        {
        }

        public void DeselectWeaponFromUnit()
        {
        }

        public void SelectWeaponFromEquipmentPanel()
        {
        }
    }
}
