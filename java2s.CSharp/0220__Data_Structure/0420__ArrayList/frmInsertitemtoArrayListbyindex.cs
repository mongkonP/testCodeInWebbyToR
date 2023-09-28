using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0420__ArrayList
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/InsertitemtoArrayListbyindex.htm
    public partial  class frmInsertitemtoArrayListbyindex:Form
    {
        public frmInsertitemtoArrayListbyindex()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInsertitemtoArrayListbyindex
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInsertitemtoArrayListbyindex";
            this.Text = "frmInsertitemtoArrayListbyindex";
            this.Load += new System.EventHandler(this.frmInsertitemtoArrayListbyindex_Load);
            this.ResumeLayout(false);

        }

        private void frmInsertitemtoArrayListbyindex_Load(object sender, EventArgs e)
        {

        }
    }
}
