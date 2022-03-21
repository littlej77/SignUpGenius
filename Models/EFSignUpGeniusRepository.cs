﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SignUpGenius.Models
{
    public class EFSignUpGeniusRepository : ISignUpGeniusRepository
    {
        
        private SignUpGeniusContext context { get; set; }
        public EFSignUpGeniusRepository (SignUpGeniusContext temp)
        {
            context = temp;
        }


        public IQueryable<FormResponse> FormResponses => context.FormResponses;
    }
}