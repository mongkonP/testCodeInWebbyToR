using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0220__RadioButton
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/RadioButtonImage.htm
    public partial  class frmRadioButtonImage:Form
    {
        public frmRadioButtonImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRadioButtonImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRadioButtonImage";
            this.Text = "frmRadioButtonImage";
            this.Load += new System.EventHandler(this.frmRadioButtonImage_Load);
            this.ResumeLayout(false);

        }

        private void frmRadioButtonImage_Load(object sender, EventArgs e)
        {

        }
    }
}
