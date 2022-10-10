using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0700__TabControl
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CustomerEntryApplicationwithTabControl.htm
    public partial  class frmCustomerEntryApplicationwithTabControl:Form
    {
        public frmCustomerEntryApplicationwithTabControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomerEntryApplicationwithTabControl
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomerEntryApplicationwithTabControl";
            this.Text = "frmCustomerEntryApplicationwithTabControl";
            this.Load += new System.EventHandler(this.frmCustomerEntryApplicationwithTabControl_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomerEntryApplicationwithTabControl_Load(object sender, EventArgs e)
        {

        }
    }
}
