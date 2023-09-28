using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThrowApplicationeventfrombuttonclickeventhandler.htm
    public partial  class frmThrowApplicationeventfrombuttonclickeventhandler:Form
    {
        public frmThrowApplicationeventfrombuttonclickeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThrowApplicationeventfrombuttonclickeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThrowApplicationeventfrombuttonclickeventhandler";
            this.Text = "frmThrowApplicationeventfrombuttonclickeventhandler";
            this.Load += new System.EventHandler(this.frmThrowApplicationeventfrombuttonclickeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmThrowApplicationeventfrombuttonclickeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
