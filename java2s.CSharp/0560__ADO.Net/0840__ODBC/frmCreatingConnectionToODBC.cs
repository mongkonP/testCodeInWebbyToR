using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0840__ODBC
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/CreatingConnectionToODBC.htm
    public partial  class frmCreatingConnectionToODBC:Form
    {
        public frmCreatingConnectionToODBC()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingConnectionToODBC
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingConnectionToODBC";
            this.Text = "frmCreatingConnectionToODBC";
            this.Load += new System.EventHandler(this.frmCreatingConnectionToODBC_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingConnectionToODBC_Load(object sender, EventArgs e)
        {

        }
    }
}
