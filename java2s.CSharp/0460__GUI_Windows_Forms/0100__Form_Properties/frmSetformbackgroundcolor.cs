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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Setformbackgroundcolor.htm
    public partial  class frmSetformbackgroundcolor:Form
    {
        public frmSetformbackgroundcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetformbackgroundcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetformbackgroundcolor";
            this.Text = "frmSetformbackgroundcolor";
            this.Load += new System.EventHandler(this.frmSetformbackgroundcolor_Load);
            this.ResumeLayout(false);

        }

        private void frmSetformbackgroundcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
