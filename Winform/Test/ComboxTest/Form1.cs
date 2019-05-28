using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //PopulateComboBox();
            var profiles = new[]
            {
                new {Name = "采集回波", Value = 0},
                new {Name = "计算回波", Value = 1},
                new {Name = "回波信号", Value = 2},
                new {Name = "逻辑曲线", Value = 3}
            };

            cbxTest.DataSource = profiles;
            cbxTest.DisplayMember = "Name";
            cbxTest.ValueMember = "Value";
        }
        private void PopulateComboBox()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(2324, "Toronto");
            dict.Add(64547, "Vancouver");
            dict.Add(42329, "Foobar");

            cbxTest.DataSource = new BindingSource(dict, null);
            cbxTest.DisplayMember = "Value";
            cbxTest.ValueMember = "Key";
        }
    }
}
