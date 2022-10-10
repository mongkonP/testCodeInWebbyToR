using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0060__SQL_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreatingSQLConnections.htm
    public partial  class frmCreatingSQLConnections:Form
    {
        public frmCreatingSQLConnections()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingSQLConnections
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingSQLConnections";
            this.Text = "frmCreatingSQLConnections";
            this.Load += new System.EventHandler(this.frmCreatingSQLConnections_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingSQLConnections_Load(object sender, EventArgs e)
        {

        }
    }
}
