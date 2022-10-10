using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Indexpointer.htm
    public partial  class frmIndexpointer:Form
    {
        public frmIndexpointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndexpointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndexpointer";
            this.Text = "frmIndexpointer";
            this.Load += new System.EventHandler(this.frmIndexpointer_Load);
            this.ResumeLayout(false);

        }

        private void frmIndexpointer_Load(object sender, EventArgs e)
        {

        }
    }
}
