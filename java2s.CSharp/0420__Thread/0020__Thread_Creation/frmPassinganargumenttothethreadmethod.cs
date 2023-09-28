using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Passinganargumenttothethreadmethod.htm
    public partial  class frmPassinganargumenttothethreadmethod:Form
    {
        public frmPassinganargumenttothethreadmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassinganargumenttothethreadmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassinganargumenttothethreadmethod";
            this.Text = "frmPassinganargumenttothethreadmethod";
            this.Load += new System.EventHandler(this.frmPassinganargumenttothethreadmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmPassinganargumenttothethreadmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
