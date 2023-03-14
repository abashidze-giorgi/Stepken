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
    public partial class UCItem : UserControl
    {

        public UCItem()
        {
            InitializeComponent();
        }
        private Dictionary<string, double> _propertyValue;

        public Dictionary<string, double> PropertyValue
        {
            get { return _propertyValue; }
            set { _propertyValue = value; AddPropertyesToPanel(); }
        }

        private void AddPropertyesToPanel()
        {
            foreach (var p in PropertyValue)
            {
                Label label = new Label();
                label.Text = $"{p.Key} - {p.Value}";
                PropertyPanel.Controls.Add(label);
            }
        }
    }
}
