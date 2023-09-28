using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0040__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/Callparentconstructorfromabstractclass.htm
    public partial  class frmCallparentconstructorfromabstractclass:Form
    {
        public frmCallparentconstructorfromabstractclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallparentconstructorfromabstractclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallparentconstructorfromabstractclass";
            this.Text = "frmCallparentconstructorfromabstractclass";
            this.Load += new System.EventHandler(this.frmCallparentconstructorfromabstractclass_Load);
            this.ResumeLayout(false);

        }

        private void frmCallparentconstructorfromabstractclass_Load(object sender, EventArgs e)
        {

        }
    }
}
