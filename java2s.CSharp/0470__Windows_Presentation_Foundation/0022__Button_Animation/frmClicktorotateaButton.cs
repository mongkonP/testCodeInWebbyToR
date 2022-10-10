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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ClicktorotateaButton.htm
    public partial  class frmClicktorotateaButton:Form
    {
        public frmClicktorotateaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClicktorotateaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClicktorotateaButton";
            this.Text = "frmClicktorotateaButton";
            this.Load += new System.EventHandler(this.frmClicktorotateaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmClicktorotateaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
