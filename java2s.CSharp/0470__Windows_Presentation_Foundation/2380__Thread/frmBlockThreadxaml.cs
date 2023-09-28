using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2380__Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BlockThreadxaml.htm
    public partial  class frmBlockThreadxaml:Form
    {
        public frmBlockThreadxaml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBlockThreadxaml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBlockThreadxaml";
            this.Text = "frmBlockThreadxaml";
            this.Load += new System.EventHandler(this.frmBlockThreadxaml_Load);
            this.ResumeLayout(false);

        }

        private void frmBlockThreadxaml_Load(object sender, EventArgs e)
        {

        }
    }
}
