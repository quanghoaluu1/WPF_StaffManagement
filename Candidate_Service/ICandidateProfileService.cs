using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    interface ICandidateProfileService
    {
        public List<CandidateProfile> GetCandidateProfilesList();
        public CandidateProfile GetCandidateProfileById(String id);
        public void AddCandidateProfile(CandidateProfile candidateProfile);
        public void RemoveCandidateProfile(String id);
        public void UpdateCandidateProfile(CandidateProfile candidate);
    }
}
