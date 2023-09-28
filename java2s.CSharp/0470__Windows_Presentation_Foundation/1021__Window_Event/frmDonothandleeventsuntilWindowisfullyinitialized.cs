using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DonothandleeventsuntilWindowisfullyinitialized.htm
    public partial  class frmDonothandleeventsuntilWindowisfullyinitialized:Form
    {
        public frmDonothandleeventsuntilWindowisfullyinitialized()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDonothandleeventsuntilWindowisfullyinitialized
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDonothandleeventsuntilWindowisfullyinitialized";
            this.Text = "frmDonothandleeventsuntilWindowisfullyinitialized";
            this.Load += new System.EventHandler(this.frmDonothandleeventsuntilWindowisfullyinitialized_Load);
            this.ResumeLayout(false);

        }

        private void frmDonothandleeventsuntilWindowisfullyinitialized_Load(object sender, EventArgs e)
        {

        }
    }
}
