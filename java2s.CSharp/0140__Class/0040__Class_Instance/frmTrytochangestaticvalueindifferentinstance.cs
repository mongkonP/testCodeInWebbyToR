using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0040__Class_Instance
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Trytochangestaticvalueindifferentinstance.htm
    public partial  class frmTrytochangestaticvalueindifferentinstance:Form
    {
        public frmTrytochangestaticvalueindifferentinstance()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTrytochangestaticvalueindifferentinstance
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTrytochangestaticvalueindifferentinstance";
            this.Text = "frmTrytochangestaticvalueindifferentinstance";
            this.Load += new System.EventHandler(this.frmTrytochangestaticvalueindifferentinstance_Load);
            this.ResumeLayout(false);

        }

        private void frmTrytochangestaticvalueindifferentinstance_Load(object sender, EventArgs e)
        {

        }
    }
}
