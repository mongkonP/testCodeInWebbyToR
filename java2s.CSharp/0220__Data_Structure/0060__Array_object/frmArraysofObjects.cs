using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0060__Array_object
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArraysofObjects.htm
    public partial  class frmArraysofObjects:Form
    {
        public frmArraysofObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArraysofObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArraysofObjects";
            this.Text = "frmArraysofObjects";
            this.Load += new System.EventHandler(this.frmArraysofObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmArraysofObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
