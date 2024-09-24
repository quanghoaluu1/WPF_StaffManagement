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
        private CandidateManagementContext dbContext;
        private static CandidateProfileDAO instance;

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
            dbContext = new CandidateManagementContext();
        }
        public CandidateProfile GetCandidateProfileById(String id)
        {
            return dbContext.CandidateProfiles.SingleOrDefault(m => m.CandidateId.Equals(id));
        }

        public List<CandidateProfile> GetCandidatesProfilesList()
        {
            return dbContext.CandidateProfiles.ToList();
        }

        public bool AddCandidateProfile(CandidateProfile candidateProfile)
        {
            bool result = false;
            CandidateProfile candidate = this.GetCandidateProfileById(candidateProfile.CandidateId);
            try
            {
                if (candidate == null)
                {
                    dbContext.CandidateProfiles.Add(candidateProfile);
                    dbContext.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool RemoveCandidateProfile(String profileId)
        {
            bool result = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(profileId);
            try
            {
                if (candidateProfile != null)
                {
                    dbContext.CandidateProfiles.Remove(candidateProfile);
                    dbContext.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool UpdateCandidateProfile(String id)
        {
            bool result = false;
            CandidateProfile candidateProfile = this.GetCandidateProfileById(id);
            try
            {
                if (candidateProfile != null)
                {
                    
                    dbContext.Entry<CandidateProfile>(candidateProfile).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbContext.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }
    }
}
