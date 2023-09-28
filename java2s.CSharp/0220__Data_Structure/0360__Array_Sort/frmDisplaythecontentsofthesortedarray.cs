using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0360__Array_Sort
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Displaythecontentsofthesortedarray.htm
    public partial  class frmDisplaythecontentsofthesortedarray:Form
    {
        public frmDisplaythecontentsofthesortedarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythecontentsofthesortedarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythecontentsofthesortedarray";
            this.Text = "frmDisplaythecontentsofthesortedarray";
            this.Load += new System.EventHandler(this.frmDisplaythecontentsofthesortedarray_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythecontentsofthesortedarray_Load(object sender, EventArgs e)
        {

        }
    }
}
