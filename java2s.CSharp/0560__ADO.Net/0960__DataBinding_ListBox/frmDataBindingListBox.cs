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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataBindingListBox.htm
    public partial  class frmDataBindingListBox:Form
    {
        public frmDataBindingListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataBindingListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataBindingListBox";
            this.Text = "frmDataBindingListBox";
            this.Load += new System.EventHandler(this.frmDataBindingListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmDataBindingListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
