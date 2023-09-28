using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0020__IP_Address
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/GetAliasfromIPHostEntry.htm
    public partial  class frmGetAliasfromIPHostEntry:Form
    {
        public frmGetAliasfromIPHostEntry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetAliasfromIPHostEntry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetAliasfromIPHostEntry";
            this.Text = "frmGetAliasfromIPHostEntry";
            this.Load += new System.EventHandler(this.frmGetAliasfromIPHostEntry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetAliasfromIPHostEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
