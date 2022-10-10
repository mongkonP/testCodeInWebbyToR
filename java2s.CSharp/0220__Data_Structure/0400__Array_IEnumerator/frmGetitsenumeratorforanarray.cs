using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0400__Array_IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Getitsenumeratorforanarray.htm
    public partial  class frmGetitsenumeratorforanarray:Form
    {
        public frmGetitsenumeratorforanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetitsenumeratorforanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetitsenumeratorforanarray";
            this.Text = "frmGetitsenumeratorforanarray";
            this.Load += new System.EventHandler(this.frmGetitsenumeratorforanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmGetitsenumeratorforanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
