using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0020__Registry_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/Loopthroughallsubkeyscontainedinthecurrentkey.htm
    public partial  class frmLoopthroughallsubkeyscontainedinthecurrentkey:Form
    {
        public frmLoopthroughallsubkeyscontainedinthecurrentkey()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoopthroughallsubkeyscontainedinthecurrentkey
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoopthroughallsubkeyscontainedinthecurrentkey";
            this.Text = "frmLoopthroughallsubkeyscontainedinthecurrentkey";
            this.Load += new System.EventHandler(this.frmLoopthroughallsubkeyscontainedinthecurrentkey_Load);
            this.ResumeLayout(false);

        }

        private void frmLoopthroughallsubkeyscontainedinthecurrentkey_Load(object sender, EventArgs e)
        {

        }
    }
}
