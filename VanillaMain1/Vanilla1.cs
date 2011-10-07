using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VanillaMain1
{
    class VanillaOption
    {
        public VanillaOption(PayOff payoff_, double expiry_)
        {
            this.payoff = payoff_;
            this.Expiry = expiry_;
        }
        public double PayOff(double spot_)
        {
            return payoff.Do(spot_);
        }

        public double Expiry{get; private set;}
        private PayOff payoff;
    }
}
