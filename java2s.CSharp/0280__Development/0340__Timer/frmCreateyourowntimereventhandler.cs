using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Createyourowntimereventhandler.htm
    public partial  class frmCreateyourowntimereventhandler:Form
    {
        public frmCreateyourowntimereventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateyourowntimereventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateyourowntimereventhandler";
            this.Text = "frmCreateyourowntimereventhandler";
            this.Load += new System.EventHandler(this.frmCreateyourowntimereventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateyourowntimereventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
