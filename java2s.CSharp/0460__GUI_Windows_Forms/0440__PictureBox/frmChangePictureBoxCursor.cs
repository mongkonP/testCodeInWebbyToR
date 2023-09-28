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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ChangePictureBoxCursor.htm
    public partial  class frmChangePictureBoxCursor:Form
    {
        public frmChangePictureBoxCursor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangePictureBoxCursor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangePictureBoxCursor";
            this.Text = "frmChangePictureBoxCursor";
            this.Load += new System.EventHandler(this.frmChangePictureBoxCursor_Load);
            this.ResumeLayout(false);

        }

        private void frmChangePictureBoxCursor_Load(object sender, EventArgs e)
        {

        }
    }
}
