using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0140__Label
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddimagetoLabel.htm
    public partial  class frmAddimagetoLabel:Form
    {
        public frmAddimagetoLabel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddimagetoLabel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddimagetoLabel";
            this.Text = "frmAddimagetoLabel";
            this.Load += new System.EventHandler(this.frmAddimagetoLabel_Load);
            this.ResumeLayout(false);

        }

        private void frmAddimagetoLabel_Load(object sender, EventArgs e)
        {

        }
    }
}
