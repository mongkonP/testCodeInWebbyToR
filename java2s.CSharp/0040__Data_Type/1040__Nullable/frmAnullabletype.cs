using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1040__Nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Anullabletype.htm
    public partial  class frmAnullabletype:Form
    {
        public frmAnullabletype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnullabletype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnullabletype";
            this.Text = "frmAnullabletype";
            this.Load += new System.EventHandler(this.frmAnullabletype_Load);
            this.ResumeLayout(false);

        }

        private void frmAnullabletype_Load(object sender, EventArgs e)
        {

        }
    }
}
