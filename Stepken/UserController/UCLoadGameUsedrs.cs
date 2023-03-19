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
    public partial class UCLoadGameUsedrs : UserControl
    {
        public UCLoadGameUsedrs()
        {
            InitializeComponent();
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; btn_UserName.Text = value; }
        }

    }
}
