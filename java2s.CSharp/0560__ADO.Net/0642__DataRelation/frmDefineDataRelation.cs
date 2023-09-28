using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0642__DataRelation
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DefineDataRelation.htm
    public partial  class frmDefineDataRelation:Form
    {
        public frmDefineDataRelation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefineDataRelation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefineDataRelation";
            this.Text = "frmDefineDataRelation";
            this.Load += new System.EventHandler(this.frmDefineDataRelation_Load);
            this.ResumeLayout(false);

        }

        private void frmDefineDataRelation_Load(object sender, EventArgs e)
        {

        }
    }
}
