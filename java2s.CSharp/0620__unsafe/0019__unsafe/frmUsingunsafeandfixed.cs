using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Usingunsafeandfixed.htm
    public partial  class frmUsingunsafeandfixed:Form
    {
        public frmUsingunsafeandfixed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingunsafeandfixed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingunsafeandfixed";
            this.Text = "frmUsingunsafeandfixed";
            this.Load += new System.EventHandler(this.frmUsingunsafeandfixed_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingunsafeandfixed_Load(object sender, EventArgs e)
        {

        }
    }
}
