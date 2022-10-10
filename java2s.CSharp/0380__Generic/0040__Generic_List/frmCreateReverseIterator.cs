using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0040__Generic_List
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/CreateReverseIterator.htm
    public partial  class frmCreateReverseIterator:Form
    {
        public frmCreateReverseIterator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateReverseIterator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateReverseIterator";
            this.Text = "frmCreateReverseIterator";
            this.Load += new System.EventHandler(this.frmCreateReverseIterator_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateReverseIterator_Load(object sender, EventArgs e)
        {

        }
    }
}
