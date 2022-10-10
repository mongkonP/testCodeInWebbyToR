using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0920__DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DatabindingforMultipleControls.htm
    public partial  class frmDatabindingforMultipleControls:Form
    {
        public frmDatabindingforMultipleControls()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDatabindingforMultipleControls
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDatabindingforMultipleControls";
            this.Text = "frmDatabindingforMultipleControls";
            this.Load += new System.EventHandler(this.frmDatabindingforMultipleControls_Load);
            this.ResumeLayout(false);

        }

        private void frmDatabindingforMultipleControls_Load(object sender, EventArgs e)
        {

        }
    }
}
