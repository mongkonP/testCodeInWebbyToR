using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoanADONETDataSet.htm
    public partial  class frmBindtoanADONETDataSet:Form
    {
        public frmBindtoanADONETDataSet()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoanADONETDataSet
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoanADONETDataSet";
            this.Text = "frmBindtoanADONETDataSet";
            this.Load += new System.EventHandler(this.frmBindtoanADONETDataSet_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoanADONETDataSet_Load(object sender, EventArgs e)
        {

        }
    }
}
