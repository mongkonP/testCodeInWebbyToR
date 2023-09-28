using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0360__SqlCommand_Insert
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/InsertingDataUsingSQLStatements.htm
    public partial  class frmInsertingDataUsingSQLStatements:Form
    {
        public frmInsertingDataUsingSQLStatements()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertingDataUsingSQLStatements
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertingDataUsingSQLStatements";
            this.Text = "frmInsertingDataUsingSQLStatements";
            this.Load += new System.EventHandler(this.frmInsertingDataUsingSQLStatements_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertingDataUsingSQLStatements_Load(object sender, EventArgs e)
        {

        }
    }
}
