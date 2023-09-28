using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0240__DllImport
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/APIFilereader.htm
    public partial  class frmAPIFilereader:Form
    {
        public frmAPIFilereader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAPIFilereader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAPIFilereader";
            this.Text = "frmAPIFilereader";
            this.Load += new System.EventHandler(this.frmAPIFilereader_Load);
            this.ResumeLayout(false);

        }

        private void frmAPIFilereader_Load(object sender, EventArgs e)
        {

        }
    }
}
