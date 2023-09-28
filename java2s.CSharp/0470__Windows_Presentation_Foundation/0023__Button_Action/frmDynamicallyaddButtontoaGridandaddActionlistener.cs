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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DynamicallyaddButtontoaGridandaddActionlistener.htm
    public partial  class frmDynamicallyaddButtontoaGridandaddActionlistener:Form
    {
        public frmDynamicallyaddButtontoaGridandaddActionlistener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDynamicallyaddButtontoaGridandaddActionlistener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDynamicallyaddButtontoaGridandaddActionlistener";
            this.Text = "frmDynamicallyaddButtontoaGridandaddActionlistener";
            this.Load += new System.EventHandler(this.frmDynamicallyaddButtontoaGridandaddActionlistener_Load);
            this.ResumeLayout(false);

        }

        private void frmDynamicallyaddButtontoaGridandaddActionlistener_Load(object sender, EventArgs e)
        {

        }
    }
}
