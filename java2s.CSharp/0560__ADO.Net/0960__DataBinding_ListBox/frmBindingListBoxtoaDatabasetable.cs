using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0960__DataBinding_ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/BindingListBoxtoaDatabasetable.htm
    public partial  class frmBindingListBoxtoaDatabasetable:Form
    {
        public frmBindingListBoxtoaDatabasetable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindingListBoxtoaDatabasetable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindingListBoxtoaDatabasetable";
            this.Text = "frmBindingListBoxtoaDatabasetable";
            this.Load += new System.EventHandler(this.frmBindingListBoxtoaDatabasetable_Load);
            this.ResumeLayout(false);

        }

        private void frmBindingListBoxtoaDatabasetable_Load(object sender, EventArgs e)
        {

        }
    }
}
