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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/SetFormBorderStyle.htm
    public partial  class frmSetFormBorderStyle:Form
    {
        public frmSetFormBorderStyle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetFormBorderStyle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetFormBorderStyle";
            this.Text = "frmSetFormBorderStyle";
            this.Load += new System.EventHandler(this.frmSetFormBorderStyle_Load);
            this.ResumeLayout(false);

        }

        private void frmSetFormBorderStyle_Load(object sender, EventArgs e)
        {

        }
    }
}
