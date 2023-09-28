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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/NormalPictureBox.htm
    public partial  class frmNormalPictureBox:Form
    {
        public frmNormalPictureBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNormalPictureBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNormalPictureBox";
            this.Text = "frmNormalPictureBox";
            this.Load += new System.EventHandler(this.frmNormalPictureBox_Load);
            this.ResumeLayout(false);

        }

        private void frmNormalPictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
