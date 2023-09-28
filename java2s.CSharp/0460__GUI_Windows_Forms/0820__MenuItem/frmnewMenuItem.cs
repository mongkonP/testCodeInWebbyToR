using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0820__MenuItem
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/newMenuItem.htm
    public partial  class frmnewMenuItem:Form
    {
        public frmnewMenuItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmnewMenuItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmnewMenuItem";
            this.Text = "frmnewMenuItem";
            this.Load += new System.EventHandler(this.frmnewMenuItem_Load);
            this.ResumeLayout(false);

        }

        private void frmnewMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
