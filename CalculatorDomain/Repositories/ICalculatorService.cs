using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDomain.Repositories
{
    public interface ICalculatorService
    {
        double Add(double x1, double x2);
        double Subtract(double x1, double x2);
        double Multiply(double x1, double x2);
        double Divide(double x1, double x2);
    }
}
