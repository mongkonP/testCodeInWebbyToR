using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0380__SqlCommand_Select
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SimpleQuery.htm
    public partial  class frmSimpleQuery:Form
    {
        public frmSimpleQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleQuery";
            this.Text = "frmSimpleQuery";
            this.Load += new System.EventHandler(this.frmSimpleQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
