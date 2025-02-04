﻿using InfoJobs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoJobs.Domain.Interfaces
{
    public interface IExperienceRepository
    {
        // Commands:
        void Add(CandidateExperience exp);

        void Delete(CandidateExperience exp);

        void Update(CandidateExperience exp);



        // Queries:
        IEnumerable<CandidateExperience> List();

        CandidateExperience SearchById(Guid? id);

        List<CandidateExperience> SearchExperienceByCandidate(Guid? idCandidate);

    }
}
