﻿using Candidate_BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Repository
{
    public interface ICandidateProfileRepo
    {
        public List<CandidateProfile> GetCandidateProfilesList();
        public CandidateProfile GetCandidateProfileById(String id);
        public bool AddCandidateProfile(CandidateProfile candidateProfile);
        public bool RemoveCandidateProfile(String id);
        public bool UpdateCandidateProfile(String id);

    }
}
