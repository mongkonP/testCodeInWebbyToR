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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddImageinanImageListtoaButton.htm
    public partial  class frmAddImageinanImageListtoaButton:Form
    {
        public frmAddImageinanImageListtoaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddImageinanImageListtoaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddImageinanImageListtoaButton";
            this.Text = "frmAddImageinanImageListtoaButton";
            this.Load += new System.EventHandler(this.frmAddImageinanImageListtoaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddImageinanImageListtoaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
