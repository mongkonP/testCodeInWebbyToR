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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingDataTableMappings.htm
    public partial  class frmUsingDataTableMappings:Form
    {
        public frmUsingDataTableMappings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingDataTableMappings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingDataTableMappings";
            this.Text = "frmUsingDataTableMappings";
            this.Load += new System.EventHandler(this.frmUsingDataTableMappings_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingDataTableMappings_Load(object sender, EventArgs e)
        {

        }
    }
}
