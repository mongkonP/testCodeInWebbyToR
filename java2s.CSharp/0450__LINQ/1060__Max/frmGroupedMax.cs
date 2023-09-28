using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1060__Max
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/GroupedMax.htm
    public partial  class frmGroupedMax:Form
    {
        public frmGroupedMax()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGroupedMax
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGroupedMax";
            this.Text = "frmGroupedMax";
            this.Load += new System.EventHandler(this.frmGroupedMax_Load);
            this.ResumeLayout(false);

        }

        private void frmGroupedMax_Load(object sender, EventArgs e)
        {

        }
    }
}
