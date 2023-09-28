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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/RollbackforOracledatabase.htm
    public partial  class frmRollbackforOracledatabase:Form
    {
        public frmRollbackforOracledatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRollbackforOracledatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRollbackforOracledatabase";
            this.Text = "frmRollbackforOracledatabase";
            this.Load += new System.EventHandler(this.frmRollbackforOracledatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmRollbackforOracledatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
