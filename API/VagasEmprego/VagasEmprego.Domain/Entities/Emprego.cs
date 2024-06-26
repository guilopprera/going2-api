﻿using System;
using System.Collections.Generic;

namespace VagasEmprego.Domain
{
    public class Emprego
    {

        public int Id { get; set; }
        public string Company { get; set; }
        public bool New { get; set; }
        public bool Featured { get; set; }
        public string Position { get; set; }
        public string Role { get; set; }
        public string Level { get; set; }
        public string PostedAt { get; set; }
        public string Contract { get; set; }
        public string Location { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Tools { get; set; }
    }
}