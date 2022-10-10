using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0500__double_Calculation
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/ImplementthePythagoreanTheorem.htm
    public partial  class frmImplementthePythagoreanTheorem:Form
    {
        public frmImplementthePythagoreanTheorem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementthePythagoreanTheorem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementthePythagoreanTheorem";
            this.Text = "frmImplementthePythagoreanTheorem";
            this.Load += new System.EventHandler(this.frmImplementthePythagoreanTheorem_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementthePythagoreanTheorem_Load(object sender, EventArgs e)
        {

        }
    }
}
