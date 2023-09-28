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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataRelationExample.htm
    public partial  class frmDataRelationExample:Form
    {
        public frmDataRelationExample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataRelationExample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataRelationExample";
            this.Text = "frmDataRelationExample";
            this.Load += new System.EventHandler(this.frmDataRelationExample_Load);
            this.ResumeLayout(false);

        }

        private void frmDataRelationExample_Load(object sender, EventArgs e)
        {

        }
    }
}
