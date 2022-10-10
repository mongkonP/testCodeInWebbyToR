using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0100__String_Array
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Initializestringarrays.htm
    public partial  class frmInitializestringarrays:Form
    {
        public frmInitializestringarrays()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInitializestringarrays
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInitializestringarrays";
            this.Text = "frmInitializestringarrays";
            this.Load += new System.EventHandler(this.frmInitializestringarrays_Load);
            this.ResumeLayout(false);

        }

        private void frmInitializestringarrays_Load(object sender, EventArgs e)
        {

        }
    }
}
