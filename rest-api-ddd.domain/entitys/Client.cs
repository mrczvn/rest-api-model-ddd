﻿using System;

namespace rest_api_ddd.domain.entitys
{
    public class Client : Base
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }
    }
}
        