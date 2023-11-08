using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepWiseBuilder
{
    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int size);
    }
}
