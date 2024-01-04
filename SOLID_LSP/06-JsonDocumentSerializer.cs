﻿using Newtonsoft.Json;
using SOLID_Entities;
using System.Collections.Generic;

namespace SOLID_LSP
{
    public class JsonDocumentSerializer : IDocumentSerializer
    {
        public string Serilize(List<Person> doc)
        {
            return JsonConvert.SerializeObject(doc);
        }
    }
}