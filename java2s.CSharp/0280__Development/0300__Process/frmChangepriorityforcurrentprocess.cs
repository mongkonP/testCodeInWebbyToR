using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Changepriorityforcurrentprocess.htm
    public partial  class frmChangepriorityforcurrentprocess:Form
    {
        public frmChangepriorityforcurrentprocess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangepriorityforcurrentprocess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangepriorityforcurrentprocess";
            this.Text = "frmChangepriorityforcurrentprocess";
            this.Load += new System.EventHandler(this.frmChangepriorityforcurrentprocess_Load);
            this.ResumeLayout(false);

        }

        private void frmChangepriorityforcurrentprocess_Load(object sender, EventArgs e)
        {

        }
    }
}
