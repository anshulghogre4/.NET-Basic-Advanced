using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartThirteen
{
    class PowerButton : ICommand
    {
        IElectronicDevice _device;

        public PowerButton(IElectronicDevice device)
        {
            this._device = device;
        }

        public void Execute()
        {
            _device.On();
        }

        public void Undo()
        {
            _device.Off();

        }
    }
}
