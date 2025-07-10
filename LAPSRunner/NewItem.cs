using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAPSRunner
{
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        public NewItem(string Name, int num) : this()
        {
            this.Text = "Edit";
            txtName.Text = Name;
            numInstanceCount.Value = num;
        }
    }
}
