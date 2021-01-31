using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorASPCORE.Functions.Query
{
    public class GetAllPostsQuery
        : IRequest<List<Post>>
    {
        public OrderByPostOptions OrderBy { get; set; }
    }
}
