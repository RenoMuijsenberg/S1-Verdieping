using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
    class TrafficLight
    {
        private TrafficlightColors color;
        private enum TrafficlightColors
        {
            Red,
            Orange,
            Green
        }

        public TrafficLight()
        {
            color = TrafficlightColors.Red;
        }

        public string GetCurrentColor()
        {
            return color.ToString();
        }

        public string NextState()
        {
            if (color == TrafficlightColors.Red)
            {
                color = TrafficlightColors.Green;
            } 
            else if (color == TrafficlightColors.Green)
            {
                color = TrafficlightColors.Orange;
            }
            else
            {
                color = TrafficlightColors.Red;
            }
            return color.ToString();
        }
    }
}
