using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0120__Multi_Dimensional_Array
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Atwodimensionalarray.htm
    public partial  class frmAtwodimensionalarray:Form
    {
        public frmAtwodimensionalarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAtwodimensionalarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAtwodimensionalarray";
            this.Text = "frmAtwodimensionalarray";
            this.Load += new System.EventHandler(this.frmAtwodimensionalarray_Load);
            this.ResumeLayout(false);

        }

        private void frmAtwodimensionalarray_Load(object sender, EventArgs e)
        {

        }
    }
}
