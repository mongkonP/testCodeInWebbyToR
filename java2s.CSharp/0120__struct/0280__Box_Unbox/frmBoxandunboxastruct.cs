using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0280__Box_Unbox
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Boxandunboxastruct.htm
    public partial  class frmBoxandunboxastruct:Form
    {
        public frmBoxandunboxastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBoxandunboxastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBoxandunboxastruct";
            this.Text = "frmBoxandunboxastruct";
            this.Load += new System.EventHandler(this.frmBoxandunboxastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmBoxandunboxastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
