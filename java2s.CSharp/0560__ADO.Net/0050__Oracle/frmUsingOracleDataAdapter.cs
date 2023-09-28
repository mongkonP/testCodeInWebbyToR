using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0050__Oracle
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingOracleDataAdapter.htm
    public partial  class frmUsingOracleDataAdapter:Form
    {
        public frmUsingOracleDataAdapter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingOracleDataAdapter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingOracleDataAdapter";
            this.Text = "frmUsingOracleDataAdapter";
            this.Load += new System.EventHandler(this.frmUsingOracleDataAdapter_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingOracleDataAdapter_Load(object sender, EventArgs e)
        {

        }
    }
}
