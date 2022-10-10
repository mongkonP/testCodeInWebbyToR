using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0500__base
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usebasekeywordtoaccessfieldinthebaseclass.htm
    public partial  class frmUsebasekeywordtoaccessfieldinthebaseclass:Form
    {
        public frmUsebasekeywordtoaccessfieldinthebaseclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsebasekeywordtoaccessfieldinthebaseclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsebasekeywordtoaccessfieldinthebaseclass";
            this.Text = "frmUsebasekeywordtoaccessfieldinthebaseclass";
            this.Load += new System.EventHandler(this.frmUsebasekeywordtoaccessfieldinthebaseclass_Load);
            this.ResumeLayout(false);

        }

        private void frmUsebasekeywordtoaccessfieldinthebaseclass_Load(object sender, EventArgs e)
        {

        }
    }
}
