using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0180__Method_Recursion
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/fibonacciinC.htm
    public partial  class frmfibonacciinC:Form
    {
        public frmfibonacciinC()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmfibonacciinC
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmfibonacciinC";
            this.Text = "frmfibonacciinC";
            this.Load += new System.EventHandler(this.frmfibonacciinC_Load);
            this.ResumeLayout(false);

        }

        private void frmfibonacciinC_Load(object sender, EventArgs e)
        {

        }
    }
}
