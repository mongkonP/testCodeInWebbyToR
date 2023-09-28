using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0460__SqlDataAdapter
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PersistAddsBuilder.htm
    public partial  class frmPersistAddsBuilder:Form
    {
        public frmPersistAddsBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPersistAddsBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPersistAddsBuilder";
            this.Text = "frmPersistAddsBuilder";
            this.Load += new System.EventHandler(this.frmPersistAddsBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmPersistAddsBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
