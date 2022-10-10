using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0240__Current_Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/ContextManipulator.htm
    public partial  class frmContextManipulator:Form
    {
        public frmContextManipulator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmContextManipulator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmContextManipulator";
            this.Text = "frmContextManipulator";
            this.Load += new System.EventHandler(this.frmContextManipulator_Load);
            this.ResumeLayout(false);

        }

        private void frmContextManipulator_Load(object sender, EventArgs e)
        {

        }
    }
}
