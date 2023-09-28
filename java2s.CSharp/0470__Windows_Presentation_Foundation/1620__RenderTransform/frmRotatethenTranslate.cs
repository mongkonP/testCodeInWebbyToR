using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1620__RenderTransform
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotatethenTranslate.htm
    public partial  class frmRotatethenTranslate:Form
    {
        public frmRotatethenTranslate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotatethenTranslate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotatethenTranslate";
            this.Text = "frmRotatethenTranslate";
            this.Load += new System.EventHandler(this.frmRotatethenTranslate_Load);
            this.ResumeLayout(false);

        }

        private void frmRotatethenTranslate_Load(object sender, EventArgs e)
        {

        }
    }
}
