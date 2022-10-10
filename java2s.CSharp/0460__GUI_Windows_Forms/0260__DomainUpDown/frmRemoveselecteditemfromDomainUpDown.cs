using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0260__DomainUpDown
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RemoveselecteditemfromDomainUpDown.htm
    public partial  class frmRemoveselecteditemfromDomainUpDown:Form
    {
        public frmRemoveselecteditemfromDomainUpDown()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRemoveselecteditemfromDomainUpDown
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRemoveselecteditemfromDomainUpDown";
            this.Text = "frmRemoveselecteditemfromDomainUpDown";
            this.Load += new System.EventHandler(this.frmRemoveselecteditemfromDomainUpDown_Load);
            this.ResumeLayout(false);

        }

        private void frmRemoveselecteditemfromDomainUpDown_Load(object sender, EventArgs e)
        {

        }
    }
}
