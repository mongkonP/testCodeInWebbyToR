using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Classcancontainclass.htm
    public partial  class frmClasscancontainclass:Form
    {
        public frmClasscancontainclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmClasscancontainclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmClasscancontainclass";
            this.Text = "frmClasscancontainclass";
            this.Load += new System.EventHandler(this.frmClasscancontainclass_Load);
            this.ResumeLayout(false);

        }

        private void frmClasscancontainclass_Load(object sender, EventArgs e)
        {

        }
    }
}
