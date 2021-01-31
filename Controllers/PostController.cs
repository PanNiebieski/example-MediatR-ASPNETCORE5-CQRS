using MediatorASPCORE.Functions.Command;
using MediatorASPCORE.Functions.Command.WritePost;
using MediatorASPCORE.Functions.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorASPCORE.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PostController : Controller
    {
        [HttpGet(Name = "WritePost")]
        public async Task<ActionResult> WritePost(string message)
        {
            await _mediator.
                Publish(
                new WritePostNotification()
                {
                    WhatToWrite = message
                });

            return NoContent();
        }



        [HttpPut(Name = "UpdatePost")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody]
            UpdatePostCommand updatePostCommand)
        {
            await _mediator.Send(updatePostCommand);

            return NoContent();
        }

        private readonly IMediator _mediator;
        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name = "GetAllPosts")]
        public async Task<ActionResult<List<Post>>> GetAllPosts()
        {
            var request = new GetAllPostsQuery
            {
                OrderBy = OrderByPostOptions.ByDate
            };
            var result = await _mediator.Send(request);

            return result;
        }


    }
}
