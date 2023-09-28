using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0060__Field
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetTypefullnameandbasetypeanditsmembers.htm
    public partial  class frmGetTypefullnameandbasetypeanditsmembers:Form
    {
        public frmGetTypefullnameandbasetypeanditsmembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetTypefullnameandbasetypeanditsmembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetTypefullnameandbasetypeanditsmembers";
            this.Text = "frmGetTypefullnameandbasetypeanditsmembers";
            this.Load += new System.EventHandler(this.frmGetTypefullnameandbasetypeanditsmembers_Load);
            this.ResumeLayout(false);

        }

        private void frmGetTypefullnameandbasetypeanditsmembers_Load(object sender, EventArgs e)
        {

        }
    }
}
