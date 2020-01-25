using System;
using System.Collections.Generic;

using Ingr.SP3D.Common.Client;
using Ingr.SP3D.Common.Client.Services;
using Ingr.SP3D.Common.Middle;

namespace SP3DSetPipelineAttribute
{
    static class SP3DFilter
    { 

        public static BOCollection GetSP3DPipelines()
        {
            var pipelineFilter = new Filter();
            pipelineFilter.Definition.AddObjectType(@"Systems\PipelineSystems");

            return ClientServiceProvider.WorkingSet.GetObjectsByFilter(
                pipelineFilter, ClientServiceProvider.WorkingSet.ActiveConnection);
        }
    }
}
