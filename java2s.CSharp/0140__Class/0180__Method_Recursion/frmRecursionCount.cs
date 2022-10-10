using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0180__Method_Recursion
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/RecursionCount.htm
    public partial  class frmRecursionCount:Form
    {
        public frmRecursionCount()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRecursionCount
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRecursionCount";
            this.Text = "frmRecursionCount";
            this.Load += new System.EventHandler(this.frmRecursionCount_Load);
            this.ResumeLayout(false);

        }

        private void frmRecursionCount_Load(object sender, EventArgs e)
        {

        }
    }
}
