using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0060__Registry_Network
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/FindDNSServersandgetserverlist.htm
    public partial  class frmFindDNSServersandgetserverlist:Form
    {
        public frmFindDNSServersandgetserverlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFindDNSServersandgetserverlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFindDNSServersandgetserverlist";
            this.Text = "frmFindDNSServersandgetserverlist";
            this.Load += new System.EventHandler(this.frmFindDNSServersandgetserverlist_Load);
            this.ResumeLayout(false);

        }

        private void frmFindDNSServersandgetserverlist_Load(object sender, EventArgs e)
        {

        }
    }
}
