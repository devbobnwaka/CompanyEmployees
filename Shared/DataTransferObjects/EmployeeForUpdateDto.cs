﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record EmployeeForUpdateDto : EmployeeForManipulationDto;

        //public record EmployeeForUpdateDto(string Name, int Age, string Position);
}
