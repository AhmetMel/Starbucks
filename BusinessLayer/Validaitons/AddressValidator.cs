﻿using EntityLayer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validaitons
{
    public class AddressValidator: AbstractValidator<Address>
    {
        public AddressValidator() { }   
    }
}
