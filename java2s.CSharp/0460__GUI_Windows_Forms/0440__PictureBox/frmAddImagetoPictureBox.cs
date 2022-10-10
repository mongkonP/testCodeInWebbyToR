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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddImagetoPictureBox.htm
    public partial  class frmAddImagetoPictureBox:Form
    {
        public frmAddImagetoPictureBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddImagetoPictureBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddImagetoPictureBox";
            this.Text = "frmAddImagetoPictureBox";
            this.Load += new System.EventHandler(this.frmAddImagetoPictureBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddImagetoPictureBox_Load(object sender, EventArgs e)
        {

        }
    }
}
