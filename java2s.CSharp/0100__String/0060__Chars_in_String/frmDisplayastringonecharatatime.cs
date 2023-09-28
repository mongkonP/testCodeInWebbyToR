using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0060__Chars_in_String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Displayastringonecharatatime.htm
    public partial  class frmDisplayastringonecharatatime:Form
    {
        public frmDisplayastringonecharatatime()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayastringonecharatatime
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayastringonecharatatime";
            this.Text = "frmDisplayastringonecharatatime";
            this.Load += new System.EventHandler(this.frmDisplayastringonecharatatime_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayastringonecharatatime_Load(object sender, EventArgs e)
        {

        }
    }
}
