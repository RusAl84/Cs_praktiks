using System;
using System.Collections.Generic;
using System.Text;

namespace PieChart
{
    class PieChartElement
    {
        public string name;
        public float value;

        public PieChartElement()
        {
        }

        public PieChartElement(string _name, float _value)
        {
            name = _name;
            value = _value;
        }
    }
}
