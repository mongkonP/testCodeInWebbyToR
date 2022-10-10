using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1000__Print_Preview_Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ShowPrintPreviewDialogbeforeprintoutadocument.htm
    public partial  class frmShowPrintPreviewDialogbeforeprintoutadocument:Form
    {
        public frmShowPrintPreviewDialogbeforeprintoutadocument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowPrintPreviewDialogbeforeprintoutadocument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowPrintPreviewDialogbeforeprintoutadocument";
            this.Text = "frmShowPrintPreviewDialogbeforeprintoutadocument";
            this.Load += new System.EventHandler(this.frmShowPrintPreviewDialogbeforeprintoutadocument_Load);
            this.ResumeLayout(false);

        }

        private void frmShowPrintPreviewDialogbeforeprintoutadocument_Load(object sender, EventArgs e)
        {

        }
    }
}
