using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzCopy.collections_csharp_practice.gcr_codebase.generics.AiDrivenResumeScreeningSystem
{
    class Resume<T> where T : JobRole
    {
        private List<T> resumes = new List<T>();

        public void AddResume(T resume)
        {
            resumes.Add(resume);
        }

        public List<T> GetResumes()
        {
            return resumes;
        }
    }

}
