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
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ThreadStaticfield.htm
    public partial  class frmThreadStaticfield:Form
    {
        public frmThreadStaticfield()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadStaticfield
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadStaticfield";
            this.Text = "frmThreadStaticfield";
            this.Load += new System.EventHandler(this.frmThreadStaticfield_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadStaticfield_Load(object sender, EventArgs e)
        {

        }
    }
}
