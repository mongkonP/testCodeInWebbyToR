using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0580__DataRow
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataRowUpdate.htm
    public partial  class frmDataRowUpdate:Form
    {
        public frmDataRowUpdate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataRowUpdate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataRowUpdate";
            this.Text = "frmDataRowUpdate";
            this.Load += new System.EventHandler(this.frmDataRowUpdate_Load);
            this.ResumeLayout(false);

        }

        private void frmDataRowUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
