using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0100__Form_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/FormwithMaximizeBox.htm
    public partial  class frmFormwithMaximizeBox:Form
    {
        public frmFormwithMaximizeBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormwithMaximizeBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormwithMaximizeBox";
            this.Text = "frmFormwithMaximizeBox";
            this.Load += new System.EventHandler(this.frmFormwithMaximizeBox_Load);
            this.ResumeLayout(false);

        }

        private void frmFormwithMaximizeBox_Load(object sender, EventArgs e)
        {

        }
    }
}
