using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0080__Array_Length
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Arraysizesanddimensions.htm
    public partial  class frmArraysizesanddimensions:Form
    {
        public frmArraysizesanddimensions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArraysizesanddimensions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArraysizesanddimensions";
            this.Text = "frmArraysizesanddimensions";
            this.Load += new System.EventHandler(this.frmArraysizesanddimensions_Load);
            this.ResumeLayout(false);

        }

        private void frmArraysizesanddimensions_Load(object sender, EventArgs e)
        {

        }
    }
}
