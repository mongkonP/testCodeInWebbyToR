using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0920__DataGrid
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ProgrammaticDataDisplay.htm
    public partial  class frmProgrammaticDataDisplay:Form
    {
        public frmProgrammaticDataDisplay()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProgrammaticDataDisplay
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProgrammaticDataDisplay";
            this.Text = "frmProgrammaticDataDisplay";
            this.Load += new System.EventHandler(this.frmProgrammaticDataDisplay_Load);
            this.ResumeLayout(false);

        }

        private void frmProgrammaticDataDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
