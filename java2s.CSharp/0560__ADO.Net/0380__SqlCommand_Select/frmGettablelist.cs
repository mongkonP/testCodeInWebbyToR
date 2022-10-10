using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0380__SqlCommand_Select
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Gettablelist.htm
    public partial  class frmGettablelist:Form
    {
        public frmGettablelist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettablelist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettablelist";
            this.Text = "frmGettablelist";
            this.Load += new System.EventHandler(this.frmGettablelist_Load);
            this.ResumeLayout(false);

        }

        private void frmGettablelist_Load(object sender, EventArgs e)
        {

        }
    }
}
