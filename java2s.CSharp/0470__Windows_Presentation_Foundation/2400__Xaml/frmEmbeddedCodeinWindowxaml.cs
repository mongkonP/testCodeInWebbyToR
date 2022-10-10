using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2400__Xaml
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EmbeddedCodeinWindowxaml.htm
    public partial  class frmEmbeddedCodeinWindowxaml:Form
    {
        public frmEmbeddedCodeinWindowxaml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmbeddedCodeinWindowxaml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmbeddedCodeinWindowxaml";
            this.Text = "frmEmbeddedCodeinWindowxaml";
            this.Load += new System.EventHandler(this.frmEmbeddedCodeinWindowxaml_Load);
            this.ResumeLayout(false);

        }

        private void frmEmbeddedCodeinWindowxaml_Load(object sender, EventArgs e)
        {

        }
    }
}
