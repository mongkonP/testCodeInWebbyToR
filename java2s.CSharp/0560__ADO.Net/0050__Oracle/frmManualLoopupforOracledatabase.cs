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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ManualLoopupforOracledatabase.htm
    public partial  class frmManualLoopupforOracledatabase:Form
    {
        public frmManualLoopupforOracledatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmManualLoopupforOracledatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmManualLoopupforOracledatabase";
            this.Text = "frmManualLoopupforOracledatabase";
            this.Load += new System.EventHandler(this.frmManualLoopupforOracledatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmManualLoopupforOracledatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
