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
    public partial class UCStore : UserControl, IItemPanel
    {
        public UCStore()
        {
            InitializeComponent();
            AddWeaponToStorePanel();

        }

        public void AddWeaponToStorePanel()
        {
            foreach (WeaponModel weapon in CreateWeaponList.WeaponFullList)
            {
                UCItem item = new UCItem();
                item.Name = weapon.Name;
                Dictionary<string, string> itemPropertyes = new Dictionary<string, string>();
                itemPropertyes.Add("Id", weapon.Id.ToString());
                itemPropertyes.Add("Name", weapon.Name.ToString());
                itemPropertyes.Add("Attack", weapon.AttackPower.ToString());
                itemPropertyes.Add("Accuracy", weapon.Accuracy.ToString());
                item.AddItemCharactersAndValues(itemPropertyes);
                item.Price = weapon.Price;
                item.ImageAddress = weapon.ImageAddress;
                Flow_weapon.Controls.Add(item);
            }
        }

        public void DeselectWeaponFromUnit()
        {
        }

        public void SelectWeaponFromStorePanel()
        {
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
        }

        private void UCStore_Load(object sender, EventArgs e)
        {
        }
    }
}
