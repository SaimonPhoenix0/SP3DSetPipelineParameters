using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP3DSetPipelineAttribute
{
    public class PipelineParameter
    {
        public string PipelineName { get; set; }
        public string OldDesignMinTemperature { get; set; }
        public string OldDesignMaxTemperature { get; set; }
        public double? NewDesignMinTemperature { get; set; }
        public double? NewDesignMaxTemperature { get; set; }
    }
}
