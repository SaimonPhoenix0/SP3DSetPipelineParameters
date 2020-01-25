using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingr.SP3D.Common.Middle;
using Ingr.SP3D.Systems.Middle;
using Ingr.SP3D.Common.Client.Services;
using Ingr.SP3D.Common.Middle.Services;

namespace SP3DSetPipelineAttribute
{
    class PipelineDefaultTemperatureAndPressure
    {
        private const string interfaceFromPipelineDefaultTemperatureAndPressure = "IJSASSTemperatureAndPressureDefaults";
        private Pipeline pipeline;  

        public PipelineDefaultTemperatureAndPressure(Pipeline pipeline)
        {
            this.pipeline = pipeline;
        }  

        public bool IsSupportInterface()
        {
            return pipeline.SupportsInterface(interfaceFromPipelineDefaultTemperatureAndPressure);
        }

        public PropertyValueDouble GetProperty(string propertyName)
        {
            return (PropertyValueDouble)pipeline.GetPropertyValue(interfaceFromPipelineDefaultTemperatureAndPressure, propertyName);
        }

        public void SetProperty(double? value, string propertyName)
        {
            if (value != null)
            {
                pipeline.SetPropertyValue(
                    MiddleServiceProvider.UOMMgr.ParseUnit(
                        UnitType.Temperature,
                        value.ToString()),
                        interfaceFromPipelineDefaultTemperatureAndPressure,
                        propertyName);
                ClientServiceProvider.TransactionMgr.Commit("Modify property: " + propertyName + ", new value: " + value + "");
            }
        }
    }
}
