using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteControlTV.Model
{
    public abstract class RemoteControl
    {
        // this is arregation
        protected TV _implementor;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="implementor"></param>
        public RemoteControl(TV implementor)
        {
            _implementor = implementor;
        }

        public virtual void On() { _implementor.On(); }

        public virtual void Off() { _implementor.Off(); }

        public virtual void SetChannel(int channel) { _implementor.TuneChannel(channel); }
    }
}
