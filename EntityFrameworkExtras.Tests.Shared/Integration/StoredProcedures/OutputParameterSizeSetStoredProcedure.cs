﻿using System;
using System.Data;

#if EF5
using EntityFrameworkExtras.EF5;
#elif EF6
using EntityFrameworkExtras.EF6;
#elif EFCORE
using EntityFrameworkExtras.EFCore;
#endif

namespace EntityFrameworkExtras.Tests.Integration.StoredProcedures
{
    [StoredProcedure("ParameterDirectionStoredProcedure")]
    public class OutputParameterSizeSetStoredProcedure
    {

        [StoredProcedureParameter(SqlDbType.NVarChar, Direction = ParameterDirection.InputOutput, Size = 10)]
        public String ParameterDirectionInputOutput { get; set; }

        [StoredProcedureParameter(SqlDbType.NVarChar, Direction = ParameterDirection.Output, Size = 10)]
        public String ParameterDirectionOutput { get; set; }
    }
}