using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1620__DataBinding_TextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DataBindingStringCollection.htm
    public partial  class frmDataBindingStringCollection:Form
    {
        public frmDataBindingStringCollection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataBindingStringCollection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataBindingStringCollection";
            this.Text = "frmDataBindingStringCollection";
            this.Load += new System.EventHandler(this.frmDataBindingStringCollection_Load);
            this.ResumeLayout(false);

        }

        private void frmDataBindingStringCollection_Load(object sender, EventArgs e)
        {

        }
    }
}
