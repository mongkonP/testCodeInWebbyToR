using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0900__yield
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/SimpleIterator.htm
    public partial  class frmSimpleIterator:Form
    {
        public frmSimpleIterator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleIterator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleIterator";
            this.Text = "frmSimpleIterator";
            this.Load += new System.EventHandler(this.frmSimpleIterator_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleIterator_Load(object sender, EventArgs e)
        {

        }
    }
}
