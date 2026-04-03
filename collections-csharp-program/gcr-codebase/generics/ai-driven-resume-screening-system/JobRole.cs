using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.AiDrivenResumeScreeningSystem
{
    abstract class JobRole
    {
        public string CandidateName { get; set; }

        public JobRole(string candidateName)
        {
            CandidateName = candidateName;
        }

        public abstract void Evaluate();
    }

}
