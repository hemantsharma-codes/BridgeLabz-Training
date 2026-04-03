using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.AiDrivenResumeScreeningSystem
{
    class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer(string candidateName) : base(candidateName) { }

        public override void Evaluate()
        {
            Console.WriteLine($"{CandidateName} evaluated for Software Engineer role (DSA + Coding).");
        }
    }

}
