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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Listallprocessthreadsincurrentrunningprocesses.htm
    public partial  class frmListallprocessthreadsincurrentrunningprocesses:Form
    {
        public frmListallprocessthreadsincurrentrunningprocesses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListallprocessthreadsincurrentrunningprocesses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListallprocessthreadsincurrentrunningprocesses";
            this.Text = "frmListallprocessthreadsincurrentrunningprocesses";
            this.Load += new System.EventHandler(this.frmListallprocessthreadsincurrentrunningprocesses_Load);
            this.ResumeLayout(false);

        }

        private void frmListallprocessthreadsincurrentrunningprocesses_Load(object sender, EventArgs e)
        {

        }
    }
}
