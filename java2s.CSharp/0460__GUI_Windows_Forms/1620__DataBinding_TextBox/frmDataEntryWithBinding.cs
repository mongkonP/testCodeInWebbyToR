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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DataEntryWithBinding.htm
    public partial  class frmDataEntryWithBinding:Form
    {
        public frmDataEntryWithBinding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataEntryWithBinding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataEntryWithBinding";
            this.Text = "frmDataEntryWithBinding";
            this.Load += new System.EventHandler(this.frmDataEntryWithBinding_Load);
            this.ResumeLayout(false);

        }

        private void frmDataEntryWithBinding_Load(object sender, EventArgs e)
        {

        }
    }
}
