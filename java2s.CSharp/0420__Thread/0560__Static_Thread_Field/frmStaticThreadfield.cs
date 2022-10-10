using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0560__Static_Thread_Field
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/StaticThreadfield.htm
    public partial  class frmStaticThreadfield:Form
    {
        public frmStaticThreadfield()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticThreadfield
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticThreadfield";
            this.Text = "frmStaticThreadfield";
            this.Load += new System.EventHandler(this.frmStaticThreadfield_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticThreadfield_Load(object sender, EventArgs e)
        {

        }
    }
}
