using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0620__ProcessThreadCollection
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/EnumThreadsForPid.htm
    public partial  class frmEnumThreadsForPid:Form
    {
        public frmEnumThreadsForPid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnumThreadsForPid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnumThreadsForPid";
            this.Text = "frmEnumThreadsForPid";
            this.Load += new System.EventHandler(this.frmEnumThreadsForPid_Load);
            this.ResumeLayout(false);

        }

        private void frmEnumThreadsForPid_Load(object sender, EventArgs e)
        {

        }
    }
}
