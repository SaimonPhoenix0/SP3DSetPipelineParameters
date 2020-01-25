using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ingr.SP3D.Common.Client;
using Ingr.SP3D.Common.Client.Services;
using Ingr.SP3D.Systems.Middle;
using Ingr.SP3D.Common.Middle.Services;


namespace SP3DSetPipelineAttribute
{
    class MyCustomCommand
    {
        private BOCollection boPipelines;

        public MyCustomCommand()
        {
            boPipelines = SP3DFilter.GetSP3DPipelines();
            pipelinesParameters();
        } 

        private void pipelinesParameters()
        {
            foreach(Pipeline pipeline in boPipelines)
            { 
                var pipelineDefaultTemperatureAndPressure = new PipelineDefaultTemperatureAndPressure(pipeline);

                if (pipelineDefaultTemperatureAndPressure.IsSupportInterface())
                {
                    var pipelineParameter = new PipelineParameter();
                    pipelineParameter.PipelineName = pipeline.Name; 
                    
                    var oldDesignMinTemp = pipelineDefaultTemperatureAndPressure.GetProperty("DesignMinTemp");
                    var oldDesignMaxTemp = pipelineDefaultTemperatureAndPressure.GetProperty("DesignMaxTemp");

                    pipelineParameter.OldDesignMinTemperature =  oldDesignMinTemp.PropValue != null ? 
                        MiddleServiceProvider.UOMMgr.FormatUnit(oldDesignMinTemp, UnitName.TEMPERATURE_CELCIUS) : String.Empty;

                    pipelineParameter.OldDesignMaxTemperature = oldDesignMaxTemp.PropValue != null ?
                        MiddleServiceProvider.UOMMgr.FormatUnit(oldDesignMaxTemp, UnitName.TEMPERATURE_CELCIUS) : String.Empty;
      

                    using(FrmPipelineParameters frmPipelineParameters = new FrmPipelineParameters(pipelineParameter))
                    {
                        frmPipelineParameters.ShowDialog();

                        pipelineDefaultTemperatureAndPressure.SetProperty(pipelineParameter.NewDesignMinTemperature, "DesignMinTemp");         
                        pipelineDefaultTemperatureAndPressure.SetProperty(pipelineParameter.NewDesignMaxTemperature, "DesignMaxTemp");
                    }

                    if (IsExit()) break;
                }
            }
        } 

        private bool IsExit()
        {
            string message = "Continue?";
            var result = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes ? false : true ;
        }


    }
}
