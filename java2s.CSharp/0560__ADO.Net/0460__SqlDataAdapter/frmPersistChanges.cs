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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PersistChanges.htm
    public partial  class frmPersistChanges:Form
    {
        public frmPersistChanges()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPersistChanges
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPersistChanges";
            this.Text = "frmPersistChanges";
            this.Load += new System.EventHandler(this.frmPersistChanges_Load);
            this.ResumeLayout(false);

        }

        private void frmPersistChanges_Load(object sender, EventArgs e)
        {

        }
    }
}
