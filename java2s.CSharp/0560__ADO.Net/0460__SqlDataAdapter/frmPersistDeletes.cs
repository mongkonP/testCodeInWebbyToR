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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/PersistDeletes.htm
    public partial  class frmPersistDeletes:Form
    {
        public frmPersistDeletes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPersistDeletes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPersistDeletes";
            this.Text = "frmPersistDeletes";
            this.Load += new System.EventHandler(this.frmPersistDeletes_Load);
            this.ResumeLayout(false);

        }

        private void frmPersistDeletes_Load(object sender, EventArgs e)
        {

        }
    }
}
