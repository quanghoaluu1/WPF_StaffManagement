using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class CandidateProfileDAO
    {
        //private CandidateManagementContext dbContext;
        private static CandidateProfileDAO instance;
        private GenericDAO<CandidateProfile> candidateProfileDAO;

        public static CandidateProfileDAO Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new CandidateProfileDAO();
                }
                return instance;

            }
        }
        public CandidateProfileDAO()
        {
            candidateProfileDAO = new GenericDAO<CandidateProfile>(new CandidateManagementContext());
        }
        public CandidateProfile GetCandidateProfileById(String id)
        {
            //return dbContext.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(id));
            return candidateProfileDAO.GetById(id);
        }

        public List<CandidateProfile> GetCandidatesProfilesList()
        {
            //return dbContext.CandidateProfiles.ToList();
            return candidateProfileDAO.GetAll();
        }

        //public bool AddCandidateProfile(CandidateProfile candidateProfile)
        //{
        //    bool result = false;
        //    CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);
        //    try
        //    {
        //        if (candidate == null)
        //        {
        //            dbContext.CandidateProfiles.Add(candidateProfile);
        //            dbContext.SaveChanges();
        //            result = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return result;
        //}
        public void AddCandidateProfile(CandidateProfile candidateProfile)
        {
            candidateProfileDAO.Add(candidateProfile);
        }
        //public bool RemoveCandidateProfile(String profileId)
        //{
        //    bool result = false;
        //    CandidateProfile candidateProfile = this.GetCandidateProfileById(profileId);
        //    try
        //    {
        //        if (candidateProfile != null)
        //        {
        //            dbContext.CandidateProfiles.Remove(candidateProfile);
        //            dbContext.SaveChanges();
        //            result = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return result;
        //}
        public void RemoveCandidateProfile(String id)
        {
            candidateProfileDAO.Remove(candidateProfileDAO.GetById(id));
        }

        //public bool UpdateCandidateProfile(CandidateProfile updatedCandidate)
        //{
        //    bool result = false;
        //    CandidateProfile candidateProfile = this.GetCandidateProfileById(updatedCandidate.CandidateId);
        //    try
        //    {
        //        if (candidateProfile != null)
        //        {
        //            candidateProfile.Fullname = updatedCandidate.Fullname;
        //            candidateProfile.Birthday = updatedCandidate.Birthday;
        //            candidateProfile.ProfileShortDescription = updatedCandidate.ProfileShortDescription;
        //            candidateProfile.ProfileUrl = updatedCandidate.ProfileUrl;
        //            candidateProfile.PostingId = updatedCandidate.PostingId;

        //            dbContext.Entry<CandidateProfile>(candidateProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //            dbContext.Update(candidateProfile);
        //            dbContext.SaveChanges();
        //            result = true;  
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return result;
        //}
        public void UpdateCandidateProfile(CandidateProfile candidateProfile)
        {
            candidateProfileDAO.Update(candidateProfile);
        }
    }
}
