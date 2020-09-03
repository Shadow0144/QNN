using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QNN
{
    class QNN
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                // Run Hello World and wait for finish
                HelloQ.Run(qsim).Wait();
            }
        }
    }
}
