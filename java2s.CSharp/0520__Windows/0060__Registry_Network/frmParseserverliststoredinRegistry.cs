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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/ParseserverliststoredinRegistry.htm
    public partial  class frmParseserverliststoredinRegistry:Form
    {
        public frmParseserverliststoredinRegistry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParseserverliststoredinRegistry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParseserverliststoredinRegistry";
            this.Text = "frmParseserverliststoredinRegistry";
            this.Load += new System.EventHandler(this.frmParseserverliststoredinRegistry_Load);
            this.ResumeLayout(false);

        }

        private void frmParseserverliststoredinRegistry_Load(object sender, EventArgs e)
        {

        }
    }
}
