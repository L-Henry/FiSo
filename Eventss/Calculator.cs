using System;
using System.Collections.Generic;
using System.Text;

namespace Eventss
{
    class Calculator
    {
        public event EventHandler BeforeCalculationEvent;
        public event EventHandler<OnCalculationEventsArgs> OnCalculationEvent;

        public void RaiseCalculationEvent(double getal1, double getal2)
        {
            /*
            if (OnCalculationEvent != null)
            {
                OnCalculationEvent(this, new OnCalculationEventsArgs(getal1, getal2));
            }
            */
            OnCalculationEvent?.Invoke(this, new OnCalculationEventsArgs(getal1, getal2));
        }

   
    }
}
