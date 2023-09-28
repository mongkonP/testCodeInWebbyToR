using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0100__OleDbCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UseOLEDBDataProvider.htm
    public partial  class frmUseOLEDBDataProvider:Form
    {
        public frmUseOLEDBDataProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseOLEDBDataProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseOLEDBDataProvider";
            this.Text = "frmUseOLEDBDataProvider";
            this.Load += new System.EventHandler(this.frmUseOLEDBDataProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmUseOLEDBDataProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
