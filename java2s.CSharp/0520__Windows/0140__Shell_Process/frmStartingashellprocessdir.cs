using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0140__Shell_Process
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Startingashellprocessdir.htm
    public partial  class frmStartingashellprocessdir:Form
    {
        public frmStartingashellprocessdir()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStartingashellprocessdir
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStartingashellprocessdir";
            this.Text = "frmStartingashellprocessdir";
            this.Load += new System.EventHandler(this.frmStartingashellprocessdir_Load);
            this.ResumeLayout(false);

        }

        private void frmStartingashellprocessdir_Load(object sender, EventArgs e)
        {

        }
    }
}
