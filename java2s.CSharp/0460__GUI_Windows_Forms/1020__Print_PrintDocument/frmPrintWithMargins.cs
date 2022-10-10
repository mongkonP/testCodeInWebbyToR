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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/PrintWithMargins.htm
    public partial  class frmPrintWithMargins:Form
    {
        public frmPrintWithMargins()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintWithMargins
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintWithMargins";
            this.Text = "frmPrintWithMargins";
            this.Load += new System.EventHandler(this.frmPrintWithMargins_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintWithMargins_Load(object sender, EventArgs e)
        {

        }
    }
}
