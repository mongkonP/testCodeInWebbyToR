using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0240__Generic_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/GenericMethodDemo.htm
    public partial  class frmGenericMethodDemo:Form
    {
        public frmGenericMethodDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericMethodDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericMethodDemo";
            this.Text = "frmGenericMethodDemo";
            this.Load += new System.EventHandler(this.frmGenericMethodDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericMethodDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
