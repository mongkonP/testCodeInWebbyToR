using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0820__IComparable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ComplexNumberImplementSystemIComparable.htm
    public partial  class frmComplexNumberImplementSystemIComparable:Form
    {
        public frmComplexNumberImplementSystemIComparable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComplexNumberImplementSystemIComparable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComplexNumberImplementSystemIComparable";
            this.Text = "frmComplexNumberImplementSystemIComparable";
            this.Load += new System.EventHandler(this.frmComplexNumberImplementSystemIComparable_Load);
            this.ResumeLayout(false);

        }

        private void frmComplexNumberImplementSystemIComparable_Load(object sender, EventArgs e)
        {

        }
    }
}
