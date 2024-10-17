using Candidate_BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_DAO
{
    public class HRAccountDAO
    {
        private static HRAccountDAO instance = null;
        private GenericDAO<Hraccount> hrAccountDAO;

        public static HRAccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HRAccountDAO();
                }
                return instance;
            }
        }



        //public HRAccountDAO()
        //{
        //    dbContext = new CandidateManagementContext();
        //}

        public HRAccountDAO()
        {
            hrAccountDAO = new GenericDAO<Hraccount>(new CandidateManagementContext());
        }

        //public Hraccount GetHraccountByEmail(string email)
        //{
        //    return dbContext.Hraccounts.SingleOrDefault(m => m.Email.Equals(email));
        //}

        public Hraccount GetHraccountByEmail(string email)
        {
            return hrAccountDAO.GetById(email);
        }

        public List<Hraccount> GetHraccountsList()
        {
            return hrAccountDAO.GetAll();
        }
    }
}
