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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SubclassPrintDocument.htm
    public partial  class frmSubclassPrintDocument:Form
    {
        public frmSubclassPrintDocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSubclassPrintDocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSubclassPrintDocument";
            this.Text = "frmSubclassPrintDocument";
            this.Load += new System.EventHandler(this.frmSubclassPrintDocument_Load);
            this.ResumeLayout(false);

        }

        private void frmSubclassPrintDocument_Load(object sender, EventArgs e)
        {

        }
    }
}
