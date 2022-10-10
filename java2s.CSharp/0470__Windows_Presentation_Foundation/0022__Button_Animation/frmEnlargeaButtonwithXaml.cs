using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0022__Button_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EnlargeaButtonwithXaml.htm
    public partial  class frmEnlargeaButtonwithXaml:Form
    {
        public frmEnlargeaButtonwithXaml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnlargeaButtonwithXaml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnlargeaButtonwithXaml";
            this.Text = "frmEnlargeaButtonwithXaml";
            this.Load += new System.EventHandler(this.frmEnlargeaButtonwithXaml_Load);
            this.ResumeLayout(false);

        }

        private void frmEnlargeaButtonwithXaml_Load(object sender, EventArgs e)
        {

        }
    }
}
