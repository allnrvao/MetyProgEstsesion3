using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace EvalueA.models
{
    internal class Evaluate
    {
        public Evaluate() { }
        public string EvalAge(int age)
        {
        if (age < 0 && age <= 12) return "Eres un nino";
        else if (age >= 13 && age <= 24) return "Eres un joven";
        else if (age >= 26) return "Eres adulto";
        return "Edad no admitida";
        }

    }
}
