using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0180__OleDbDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/TypedAccessors.htm
    public partial  class frmTypedAccessors:Form
    {
        public frmTypedAccessors()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTypedAccessors
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTypedAccessors";
            this.Text = "frmTypedAccessors";
            this.Load += new System.EventHandler(this.frmTypedAccessors_Load);
            this.ResumeLayout(false);

        }

        private void frmTypedAccessors_Load(object sender, EventArgs e)
        {

        }
    }
}
