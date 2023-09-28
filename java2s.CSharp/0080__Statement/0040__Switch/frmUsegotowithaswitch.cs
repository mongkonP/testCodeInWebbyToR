using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0040__Switch
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Usegotowithaswitch.htm
    public partial  class frmUsegotowithaswitch:Form
    {
        public frmUsegotowithaswitch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsegotowithaswitch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsegotowithaswitch";
            this.Text = "frmUsegotowithaswitch";
            this.Load += new System.EventHandler(this.frmUsegotowithaswitch_Load);
            this.ResumeLayout(false);

        }

        private void frmUsegotowithaswitch_Load(object sender, EventArgs e)
        {

        }
    }
}
