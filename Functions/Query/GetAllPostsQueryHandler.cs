using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorASPCORE.Functions.Query
{
    public class GetAllPostsQueryHandler : IRequestHandler
        <GetAllPostsQuery, List<Post>>
    {
        public Task<List<Post>> Handle(GetAllPostsQuery request,
            CancellationToken cancellationToken)
        {
            var posts = DummyPosts.Get();
            if (request.OrderBy == OrderByPostOptions.ByAuthor)
                return Task.FromResult
                    (posts.OrderBy(p => p.Author).ToList());
            else if (request.OrderBy == OrderByPostOptions.ByDate)
                return Task.FromResult
                    (posts.OrderBy(p => p.Date).ToList());
            else if (request.OrderBy == OrderByPostOptions.ByTitle)
                return Task.FromResult
                    (posts.OrderBy(p => p.Title).ToList());

            return Task.FromResult
                   (posts);
        }
    }
}
