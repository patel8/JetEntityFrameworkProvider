﻿using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace JetEntityFrameworkProvider.JetStoreSchemaDefinition
{
    class Column
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Nullable { get; set; }
        public int? MaxLength { get; set; }
    }
}
