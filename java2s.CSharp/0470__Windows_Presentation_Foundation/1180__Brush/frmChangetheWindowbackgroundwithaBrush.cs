using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1180__Brush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ChangetheWindowbackgroundwithaBrush.htm
    public partial  class frmChangetheWindowbackgroundwithaBrush:Form
    {
        public frmChangetheWindowbackgroundwithaBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangetheWindowbackgroundwithaBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangetheWindowbackgroundwithaBrush";
            this.Text = "frmChangetheWindowbackgroundwithaBrush";
            this.Load += new System.EventHandler(this.frmChangetheWindowbackgroundwithaBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmChangetheWindowbackgroundwithaBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
