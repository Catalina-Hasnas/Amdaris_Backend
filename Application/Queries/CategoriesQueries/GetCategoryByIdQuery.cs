﻿using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.CategoriesQueries
{
    public class GetCategoryByIdQuery : IRequest<Category>
    {
        public int Id { get; set; }
    }
}
