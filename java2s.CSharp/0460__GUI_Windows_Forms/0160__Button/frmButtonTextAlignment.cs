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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ButtonTextAlignment.htm
    public partial  class frmButtonTextAlignment:Form
    {
        public frmButtonTextAlignment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonTextAlignment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonTextAlignment";
            this.Text = "frmButtonTextAlignment";
            this.Load += new System.EventHandler(this.frmButtonTextAlignment_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonTextAlignment_Load(object sender, EventArgs e)
        {

        }
    }
}
