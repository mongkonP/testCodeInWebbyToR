using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0023__Button_Action
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ButtonClickeventhandler.htm
    public partial  class frmButtonClickeventhandler:Form
    {
        public frmButtonClickeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonClickeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonClickeventhandler";
            this.Text = "frmButtonClickeventhandler";
            this.Load += new System.EventHandler(this.frmButtonClickeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonClickeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
