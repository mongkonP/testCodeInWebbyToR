using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0960__MessageBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DisplayinformationwithWPFMessageBox.htm
    public partial  class frmDisplayinformationwithWPFMessageBox:Form
    {
        public frmDisplayinformationwithWPFMessageBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayinformationwithWPFMessageBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayinformationwithWPFMessageBox";
            this.Text = "frmDisplayinformationwithWPFMessageBox";
            this.Load += new System.EventHandler(this.frmDisplayinformationwithWPFMessageBox_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayinformationwithWPFMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
