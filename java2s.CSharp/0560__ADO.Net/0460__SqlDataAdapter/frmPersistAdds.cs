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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PersistAdds.htm
    public partial  class frmPersistAdds:Form
    {
        public frmPersistAdds()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPersistAdds
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPersistAdds";
            this.Text = "frmPersistAdds";
            this.Load += new System.EventHandler(this.frmPersistAdds_Load);
            this.ResumeLayout(false);

        }

        private void frmPersistAdds_Load(object sender, EventArgs e)
        {

        }
    }
}
