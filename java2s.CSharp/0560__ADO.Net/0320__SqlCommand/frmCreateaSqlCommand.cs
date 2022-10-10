using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0320__SqlCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreateaSqlCommand.htm
    public partial  class frmCreateaSqlCommand:Form
    {
        public frmCreateaSqlCommand()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaSqlCommand
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaSqlCommand";
            this.Text = "frmCreateaSqlCommand";
            this.Load += new System.EventHandler(this.frmCreateaSqlCommand_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaSqlCommand_Load(object sender, EventArgs e)
        {

        }
    }
}
