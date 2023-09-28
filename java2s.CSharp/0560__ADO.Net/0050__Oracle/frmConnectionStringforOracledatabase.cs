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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectionStringforOracledatabase.htm
    public partial  class frmConnectionStringforOracledatabase:Form
    {
        public frmConnectionStringforOracledatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectionStringforOracledatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectionStringforOracledatabase";
            this.Text = "frmConnectionStringforOracledatabase";
            this.Load += new System.EventHandler(this.frmConnectionStringforOracledatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectionStringforOracledatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
