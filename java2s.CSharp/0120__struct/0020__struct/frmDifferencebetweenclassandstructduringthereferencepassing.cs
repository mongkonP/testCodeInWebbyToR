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
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Differencebetweenclassandstructduringthereferencepassing.htm
    public partial  class frmDifferencebetweenclassandstructduringthereferencepassing:Form
    {
        public frmDifferencebetweenclassandstructduringthereferencepassing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDifferencebetweenclassandstructduringthereferencepassing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDifferencebetweenclassandstructduringthereferencepassing";
            this.Text = "frmDifferencebetweenclassandstructduringthereferencepassing";
            this.Load += new System.EventHandler(this.frmDifferencebetweenclassandstructduringthereferencepassing_Load);
            this.ResumeLayout(false);

        }

        private void frmDifferencebetweenclassandstructduringthereferencepassing_Load(object sender, EventArgs e)
        {

        }
    }
}
