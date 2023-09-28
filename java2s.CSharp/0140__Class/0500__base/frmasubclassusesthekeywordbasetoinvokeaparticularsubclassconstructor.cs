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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/asubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor.htm
    public partial  class frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor:Form
    {
        public frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor";
            this.Text = "frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor";
            this.Load += new System.EventHandler(this.frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor_Load);
            this.ResumeLayout(false);

        }

        private void frmasubclassusesthekeywordbasetoinvokeaparticularsubclassconstructor_Load(object sender, EventArgs e)
        {

        }
    }
}
