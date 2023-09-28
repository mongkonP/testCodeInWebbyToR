using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0160__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Handlebuttonmessages.htm
    public partial  class frmHandlebuttonmessages:Form
    {
        public frmHandlebuttonmessages()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlebuttonmessages
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlebuttonmessages";
            this.Text = "frmHandlebuttonmessages";
            this.Load += new System.EventHandler(this.frmHandlebuttonmessages_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlebuttonmessages_Load(object sender, EventArgs e)
        {

        }
    }
}
