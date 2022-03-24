using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public interface ISignUpGeniusRepository
    {
        IQueryable<FormResponse> FormResponses { get; }
        IQueryable<TimeSlot> TimeSlots { get; }

        public void SaveResponse(FormResponse fr);

        public void AddResponse(FormResponse fr);

        public void DeleteResponse(FormResponse fr);

        public void EditResponse(FormResponse fr);

    }
}

