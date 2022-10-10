using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0140__Jagged_Arrays
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Multidimensionaljaggedarrays.htm
    public partial  class frmMultidimensionaljaggedarrays:Form
    {
        public frmMultidimensionaljaggedarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultidimensionaljaggedarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultidimensionaljaggedarrays";
            this.Text = "frmMultidimensionaljaggedarrays";
            this.Load += new System.EventHandler(this.frmMultidimensionaljaggedarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmMultidimensionaljaggedarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
