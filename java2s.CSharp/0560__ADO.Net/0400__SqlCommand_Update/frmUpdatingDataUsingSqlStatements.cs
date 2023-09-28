using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0400__SqlCommand_Update
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UpdatingDataUsingSqlStatements.htm
    public partial  class frmUpdatingDataUsingSqlStatements:Form
    {
        public frmUpdatingDataUsingSqlStatements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUpdatingDataUsingSqlStatements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUpdatingDataUsingSqlStatements";
            this.Text = "frmUpdatingDataUsingSqlStatements";
            this.Load += new System.EventHandler(this.frmUpdatingDataUsingSqlStatements_Load);
            this.ResumeLayout(false);

        }

        private void frmUpdatingDataUsingSqlStatements_Load(object sender, EventArgs e)
        {

        }
    }
}
