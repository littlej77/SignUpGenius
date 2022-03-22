using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public interface ISignUpGeniusRepository
    {
        IQueryable<FormResponse> FormResponses { get; }

        public void SaveResponse(FormResponse fr);

        public void AddResponse(FormResponse fr);

    }
}

