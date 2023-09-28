using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2004__Bind_to_Button
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindcurrenttimetoButton.htm
    public partial  class frmBindcurrenttimetoButton:Form
    {
        public frmBindcurrenttimetoButton()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindcurrenttimetoButton
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindcurrenttimetoButton";
            this.Text = "frmBindcurrenttimetoButton";
            this.Load += new System.EventHandler(this.frmBindcurrenttimetoButton_Load);
            this.ResumeLayout(false);

        }

        private void frmBindcurrenttimetoButton_Load(object sender, EventArgs e)
        {

        }
    }
}
