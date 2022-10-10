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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetDNSserverfromRegistry.htm
    public partial  class frmGetDNSserverfromRegistry:Form
    {
        public frmGetDNSserverfromRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetDNSserverfromRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetDNSserverfromRegistry";
            this.Text = "frmGetDNSserverfromRegistry";
            this.Load += new System.EventHandler(this.frmGetDNSserverfromRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmGetDNSserverfromRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
