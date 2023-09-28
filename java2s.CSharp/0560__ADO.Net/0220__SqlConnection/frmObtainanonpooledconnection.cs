using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0220__SqlConnection
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Obtainanonpooledconnection.htm
    public partial  class frmObtainanonpooledconnection:Form
    {
        public frmObtainanonpooledconnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObtainanonpooledconnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObtainanonpooledconnection";
            this.Text = "frmObtainanonpooledconnection";
            this.Load += new System.EventHandler(this.frmObtainanonpooledconnection_Load);
            this.ResumeLayout(false);

        }

        private void frmObtainanonpooledconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
