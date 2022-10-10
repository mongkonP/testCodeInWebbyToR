using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0360__MaskedTextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SettheinputmasktothatofasecretPIN.htm
    public partial  class frmSettheinputmasktothatofasecretPIN:Form
    {
        public frmSettheinputmasktothatofasecretPIN()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSettheinputmasktothatofasecretPIN
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSettheinputmasktothatofasecretPIN";
            this.Text = "frmSettheinputmasktothatofasecretPIN";
            this.Load += new System.EventHandler(this.frmSettheinputmasktothatofasecretPIN_Load);
            this.ResumeLayout(false);

        }

        private void frmSettheinputmasktothatofasecretPIN_Load(object sender, EventArgs e)
        {

        }
    }
}
