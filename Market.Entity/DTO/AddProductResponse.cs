﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entity.DTO
{
    public class AddProductResponse:BaseApiResponse
    {
        public List<ModelProduct> ProductModels { get; set; }

    }
}
