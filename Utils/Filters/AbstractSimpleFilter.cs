﻿namespace Utils.Filters
{
    public delegate void FilterEvent(double[] data);

    public interface IFilter
    {
        event FilterEvent output;
        void InputData(double[] data);
    }
    
    /* Defines an abstract single input, single output filter
        input event -> Filter -> output event */

    public abstract class AbstractSimpleFilter : IFilter
    {
        /* When the input is received and processed this event is called on
        the filter output result. */
        public event FilterEvent output;

        /* Implements the filter function for a data chunk. */
        abstract protected double[] Filter(double[] x);
        
        /* Filters the data sample and calls the output event. */
        virtual public void InputData(double[] data)
        {
            var result = Filter(data);
            if ((result.Length > 0) && (output != null))
            {
                output(result);
            }
        }
    }
}
