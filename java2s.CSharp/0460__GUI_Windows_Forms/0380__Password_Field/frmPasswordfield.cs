using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0380__Password_Field
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Passwordfield.htm
    public partial  class frmPasswordfield:Form
    {
        public frmPasswordfield()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPasswordfield
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPasswordfield";
            this.Text = "frmPasswordfield";
            this.Load += new System.EventHandler(this.frmPasswordfield_Load);
            this.ResumeLayout(false);

        }

        private void frmPasswordfield_Load(object sender, EventArgs e)
        {

        }
    }
}
