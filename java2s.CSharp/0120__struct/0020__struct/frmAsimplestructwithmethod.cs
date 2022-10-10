using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Asimplestructwithmethod.htm
    public partial  class frmAsimplestructwithmethod:Form
    {
        public frmAsimplestructwithmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimplestructwithmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimplestructwithmethod";
            this.Text = "frmAsimplestructwithmethod";
            this.Load += new System.EventHandler(this.frmAsimplestructwithmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimplestructwithmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
