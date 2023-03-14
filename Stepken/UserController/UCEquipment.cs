using Domain.Interface;
using Domain.Models;
using Domain.Service;
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
            AddWeaponToEquipmentPanel();

        }

        public void AddWeaponToEquipmentPanel()
        {
            foreach (WeaponModel w in CreateAllEquipments.AmmunitionGlobalList)
            {
                UCItem item = new UCItem();
                item.Name = w.Name;
                Dictionary<string, string> itemPropertyes = new Dictionary<string, string>();
                itemPropertyes.Add("Id", w.Id.ToString());
                itemPropertyes.Add("Name", w.Name.ToString());
                itemPropertyes.Add("Attack", w.AttackPower.ToString());
                itemPropertyes.Add("Accuracy", w.Accuracy.ToString());
                item.AddItemCharactersAndValues(itemPropertyes);
                item.ImageAddress = w.ImageAddress;
                Flow_weapon.Controls.Add(item);
            }
        }

        public void DeselectWeaponFromUnit()
        {
        }

        public void SelectWeaponFromEquipmentPanel()
        {
        }

        private void UCEquipment_Load(object sender, EventArgs e)
        {
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
        }
    }
}
