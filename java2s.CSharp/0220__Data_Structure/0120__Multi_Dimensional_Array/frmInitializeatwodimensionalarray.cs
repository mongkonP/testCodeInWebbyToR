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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Initializeatwodimensionalarray.htm
    public partial  class frmInitializeatwodimensionalarray:Form
    {
        public frmInitializeatwodimensionalarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInitializeatwodimensionalarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInitializeatwodimensionalarray";
            this.Text = "frmInitializeatwodimensionalarray";
            this.Load += new System.EventHandler(this.frmInitializeatwodimensionalarray_Load);
            this.ResumeLayout(false);

        }

        private void frmInitializeatwodimensionalarray_Load(object sender, EventArgs e)
        {

        }
    }
}
