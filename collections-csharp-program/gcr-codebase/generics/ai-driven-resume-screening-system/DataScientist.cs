using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.AiDrivenResumeScreeningSystem
{
    class DataScientist : JobRole
    {
        public DataScientist(string candidateName) : base(candidateName) { }

        public override void Evaluate()
        {
            Console.WriteLine($"{CandidateName} evaluated for Data Scientist role (ML + Statistics).");
        }
    }

}
