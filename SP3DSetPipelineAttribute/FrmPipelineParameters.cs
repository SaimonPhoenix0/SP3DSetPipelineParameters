using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ingr.SP3D.Common.Middle.Services;

namespace SP3DSetPipelineAttribute
{
    public partial class FrmPipelineParameters : Form
    {
        private PipelineParameter pipelineParameter;
        public FrmPipelineParameters(PipelineParameter pipelineParameter)
        {
            InitializeComponent();

            this.pipelineParameter = pipelineParameter;
            this.Text = "Pipeline:" + pipelineParameter.PipelineName;
            
        }

        private void FrmPipelineParameters_Load(object sender, EventArgs e)
        {
            tbOldDesignMinTemp.Text = pipelineParameter.OldDesignMinTemperature;
            tbOldDesignMaxTemp.Text = pipelineParameter.OldDesignMaxTemperature;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double newDesignMinTemp = 0; 
            double newDesignMaxTemp = 0; 
            
            if(double.TryParse(tbNewDesignMinTemp.Text, out newDesignMinTemp))
            {
                pipelineParameter.NewDesignMinTemperature = newDesignMinTemp;
            } 
            else 
            {
                MessageBox.Show("Incorrect value: NewDesignMinTemp");
                return;
            }

            if (double.TryParse(tbNewDesignMaxTemp.Text, out newDesignMaxTemp))
            {
                pipelineParameter.NewDesignMaxTemperature = newDesignMaxTemp;
            }
            else
            {
                MessageBox.Show("Incorrect value: NewDesignMaxTemp");
                return;
            }

            Close();
        }
    }
}
