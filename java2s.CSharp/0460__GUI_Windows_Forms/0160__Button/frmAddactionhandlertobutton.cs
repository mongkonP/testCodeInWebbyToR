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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Addactionhandlertobutton.htm
    public partial  class frmAddactionhandlertobutton:Form
    {
        public frmAddactionhandlertobutton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddactionhandlertobutton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddactionhandlertobutton";
            this.Text = "frmAddactionhandlertobutton";
            this.Load += new System.EventHandler(this.frmAddactionhandlertobutton_Load);
            this.ResumeLayout(false);

        }

        private void frmAddactionhandlertobutton_Load(object sender, EventArgs e)
        {

        }
    }
}
