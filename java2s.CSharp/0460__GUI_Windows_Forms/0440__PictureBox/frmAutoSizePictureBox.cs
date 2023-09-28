using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0440__PictureBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AutoSizePictureBox.htm
    public partial  class frmAutoSizePictureBox:Form
    {
        public frmAutoSizePictureBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAutoSizePictureBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAutoSizePictureBox";
            this.Text = "frmAutoSizePictureBox";
            this.Load += new System.EventHandler(this.frmAutoSizePictureBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAutoSizePictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
