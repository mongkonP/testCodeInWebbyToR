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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/MakeanArrayListSynchronized.htm
    public partial  class frmMakeanArrayListSynchronized:Form
    {
        public frmMakeanArrayListSynchronized()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMakeanArrayListSynchronized
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMakeanArrayListSynchronized";
            this.Text = "frmMakeanArrayListSynchronized";
            this.Load += new System.EventHandler(this.frmMakeanArrayListSynchronized_Load);
            this.ResumeLayout(false);

        }

        private void frmMakeanArrayListSynchronized_Load(object sender, EventArgs e)
        {

        }
    }
}
