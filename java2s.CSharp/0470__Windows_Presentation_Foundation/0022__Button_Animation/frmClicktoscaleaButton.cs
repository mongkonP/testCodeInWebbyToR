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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ClicktoscaleaButton.htm
    public partial  class frmClicktoscaleaButton:Form
    {
        public frmClicktoscaleaButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClicktoscaleaButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClicktoscaleaButton";
            this.Text = "frmClicktoscaleaButton";
            this.Load += new System.EventHandler(this.frmClicktoscaleaButton_Load);
            this.ResumeLayout(false);

        }

        private void frmClicktoscaleaButton_Load(object sender, EventArgs e)
        {

        }
    }
}
