using System;
using Ingr.SP3D.Common.Client;

namespace SP3DSetPipelineAttribute
{
    public class SP3DModalCommand : BaseModalCommand
    {
        private MyCustomCommand myCustomCommand;
        public override void OnStart(int instanceId, object argument)
        {
            myCustomCommand = new MyCustomCommand();
            base.WriteStatusBarMsg(argument.ToString());
        }

        public override void OnStop()
        {
            base.OnStop();
        }
    }
}
