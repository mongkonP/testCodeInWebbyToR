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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ButtonBackgroundColor.htm
    public partial  class frmButtonBackgroundColor:Form
    {
        public frmButtonBackgroundColor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonBackgroundColor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonBackgroundColor";
            this.Text = "frmButtonBackgroundColor";
            this.Load += new System.EventHandler(this.frmButtonBackgroundColor_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonBackgroundColor_Load(object sender, EventArgs e)
        {

        }
    }
}
