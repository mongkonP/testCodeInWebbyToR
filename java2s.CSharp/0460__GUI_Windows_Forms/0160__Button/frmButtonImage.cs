using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ButtonImage.htm
    public partial  class frmButtonImage:Form
    {
        public frmButtonImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonImage";
            this.Text = "frmButtonImage";
            this.Load += new System.EventHandler(this.frmButtonImage_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonImage_Load(object sender, EventArgs e)
        {

        }
    }
}
