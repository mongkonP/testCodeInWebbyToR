using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0380__Exception_in_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Anexceptioncanbegeneratedbyonemethodandcaughtbyanother.htm
    public partial  class frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother:Form
    {
        public frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother";
            this.Text = "frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother";
            this.Load += new System.EventHandler(this.frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother_Load);
            this.ResumeLayout(false);

        }

        private void frmAnexceptioncanbegeneratedbyonemethodandcaughtbyanother_Load(object sender, EventArgs e)
        {

        }
    }
}
