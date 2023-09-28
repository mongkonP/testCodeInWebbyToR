using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1020__Print_PrintDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MultiPagePrint.htm
    public partial  class frmMultiPagePrint:Form
    {
        public frmMultiPagePrint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultiPagePrint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultiPagePrint";
            this.Text = "frmMultiPagePrint";
            this.Load += new System.EventHandler(this.frmMultiPagePrint_Load);
            this.ResumeLayout(false);

        }

        private void frmMultiPagePrint_Load(object sender, EventArgs e)
        {

        }
    }
}
