using Candidate_BusinessObjects;
using Candidate_DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public class CandidateProfileRepo : ICandidateProfileRepo
    {
        public List<CandidateProfile> GetCandidateProfilesList() =>
            CandidateProfileDAO.Instance.GetCandidatesProfilesList();

        public CandidateProfile GetCandidateProfileById(String id) =>
            CandidateProfileDAO.Instance.GetCandidateProfileById(id);

        public bool AddCandidateProfile(CandidateProfile candidateProfile) =>
            CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);

        public bool RemoveCandidateProfile(String id) =>
            CandidateProfileDAO.Instance.RemoveCandidateProfile(id);

        public bool UpdateCandidateProfile(String id) =>
            CandidateProfileDAO.Instance.UpdateCandidateProfile(id);
    }
}
