using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Eventfiringsequence.htm
    public partial  class frmEventfiringsequence:Form
    {
        public frmEventfiringsequence()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventfiringsequence
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventfiringsequence";
            this.Text = "frmEventfiringsequence";
            this.Load += new System.EventHandler(this.frmEventfiringsequence_Load);
            this.ResumeLayout(false);

        }

        private void frmEventfiringsequence_Load(object sender, EventArgs e)
        {

        }
    }
}
