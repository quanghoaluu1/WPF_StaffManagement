using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class JobPostingDAO
    {
    //    private CandidateManagementContext dBContext;
        private static JobPostingDAO instance;
        private GenericDAO<JobPosting> jobPostingDAO;
        public static JobPostingDAO Instance 
        { 
            get
            {
                if (instance == null)
                {
                    instance = new JobPostingDAO();
                }
                    return instance; 
            }
        }

        public JobPostingDAO()
        {
            jobPostingDAO = new GenericDAO<JobPosting>(new CandidateManagementContext());
        }

        public List<JobPosting> GetJobPostingsList()
        {
            return jobPostingDAO.GetAll();

        }

        public JobPosting getJobPostingById(String id)
        {
            return jobPostingDAO.GetById(id);
        }

    }
}
