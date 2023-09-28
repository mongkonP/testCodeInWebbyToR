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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Printaparagraph.htm
    public partial  class frmPrintaparagraph:Form
    {
        public frmPrintaparagraph()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintaparagraph
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintaparagraph";
            this.Text = "frmPrintaparagraph";
            this.Load += new System.EventHandler(this.frmPrintaparagraph_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintaparagraph_Load(object sender, EventArgs e)
        {

        }
    }
}
