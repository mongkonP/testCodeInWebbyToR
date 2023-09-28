using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0460__ArrayList_Display
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Displaythearraylistusingarrayindexing.htm
    public partial  class frmDisplaythearraylistusingarrayindexing:Form
    {
        public frmDisplaythearraylistusingarrayindexing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaythearraylistusingarrayindexing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaythearraylistusingarrayindexing";
            this.Text = "frmDisplaythearraylistusingarrayindexing";
            this.Load += new System.EventHandler(this.frmDisplaythearraylistusingarrayindexing_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaythearraylistusingarrayindexing_Load(object sender, EventArgs e)
        {

        }
    }
}
