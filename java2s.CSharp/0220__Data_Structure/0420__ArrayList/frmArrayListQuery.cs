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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayListQuery.htm
    public partial  class frmArrayListQuery:Form
    {
        public frmArrayListQuery()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayListQuery
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayListQuery";
            this.Text = "frmArrayListQuery";
            this.Load += new System.EventHandler(this.frmArrayListQuery_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayListQuery_Load(object sender, EventArgs e)
        {

        }
    }
}
