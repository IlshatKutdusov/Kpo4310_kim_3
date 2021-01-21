using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kpo4310.kim.Lib;

namespace Kpo4310.kim.Main
{
    public partial class FrmAccessory : Form
    {
        public FrmAccessory()
        {
            InitializeComponent();

            _accessory = null;
        }

        private Accessory _accessory = null;

        public Accessory accessory
        {
            get { return _accessory; }
        }

        public void SetAccessory(Accessory accessory)
        {
            this._accessory = accessory;

            this.txtboxName.Text = _accessory.name;
        }
    }
}
