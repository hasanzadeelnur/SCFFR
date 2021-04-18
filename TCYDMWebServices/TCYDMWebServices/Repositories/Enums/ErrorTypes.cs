﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDMWebServices.Repositories.Enums
{
    interface ErrorTypes
    {
        public enum Errors
        {
            Internal = 1,
            NotFound,
            ValidationFailed,
            AlreadyExists,
            WrongPassword,
            WrongUser,
            ExistedTime,
            UnfinishedQuery,
            NeedConfirmation
        }
    }
}
