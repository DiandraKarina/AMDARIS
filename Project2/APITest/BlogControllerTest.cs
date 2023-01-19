using API.DTO;
using Application.Commands.Blogs;
using AutoMapper;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
    [TestClass]
    public class BlogControllerTest
    {
        private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();
        private readonly Mock<IMapper> _mockMapper = new Mock<IMapper>();

        [TestMethod]
        public async Task CallPost_ReturnBlogDto()
        {
            var createBlogCommand= new CreateBlogCommand
            { BlogName="some name",
             ProfilePhoto="abcdef",
             UserId=1
            };

            
        }
    }
}
