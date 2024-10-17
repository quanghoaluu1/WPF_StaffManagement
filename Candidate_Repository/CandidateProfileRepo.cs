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

        public void AddCandidateProfile(CandidateProfile candidateProfile) =>
            CandidateProfileDAO.Instance.AddCandidateProfile(candidateProfile);

        public void RemoveCandidateProfile(String id) =>
            CandidateProfileDAO.Instance.RemoveCandidateProfile(id);

        public void UpdateCandidateProfile(CandidateProfile candidate) =>
            CandidateProfileDAO.Instance.UpdateCandidateProfile(candidate);
    }
}
