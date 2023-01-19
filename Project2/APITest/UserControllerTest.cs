using API.Controllers;
using API.DTO;
using Application.Queries;
using AutoMapper;
using Domain.Models;
using Domain.Models.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace APITest
{
    [TestClass]
    public class UserControllerTest
    {
        private readonly Mock<IMediator> _mockMediator = new Mock<IMediator>();
        private readonly Mock<IMapper> _mockMapper = new Mock<IMapper>();

        [TestMethod]
        public async Task Get_All_Users_GetAllUsersQueryIsCalled()
        {
            //Arrange
            _mockMediator
                .Setup(m => m.Send(It.IsAny<GetUsersQuery>(), It.IsAny<CancellationToken>()))
                .Verifiable();

            //Act
            var controller = new UserController(_mockMediator.Object, _mockMapper.Object);
            await controller.GetUsers();

            _mockMediator.Verify(x => x.Send(It.IsAny<GetUsersQuery>(), It.IsAny<CancellationToken>()), Times.Once());
        }

        [TestMethod]
        public async Task Get_User_By_Id_GetUserByIdQueryIsCalled()
        {
            var contextMock = new Mock<DbContext>();
           
        }
/*
        [TestMethod]
        public async Task Get_User_By_Id_GetUserByIdQueryIsCalled()
        {
            _mockMediator
                .Setup(m => m.Send(It.IsAny<GetUserByIdQuery>(), It.IsAny<CancellationToken>()))
                .Returns<GetUserByIdQuery, CancellationToken>(async (q, c) =>
                {
                    return await Task.FromResult(
                        new UsersGetDto
                        { 
                            FirstName = "string",
                            LastName = "string",
                            UserId = q.UserId,
                            Gender = (Gender)1,
                            DOB=new DateTime(1999,02,01),
                            EmailAddress = "string"
                           
                        });
                });
            var controller = new UserController(_mockMediator.Object, _mockMapper.Object);

            await controller.GetUserById(1);

            _mockMediator.Verify(x => x.Send(It.IsAny<GetUserByIdQuery>(), It.IsAny<CancellationToken>()), Times.Once());
        }

        */
        /*
        [TestMethod]
        public async Task Get_Book_By_Id_GetBookQueryWithCorrectBookIdIsCalled()
        {
            int bookId = 0;

            _mockMediator
                .Setup(m => m.Send(It.IsAny<GetBookQuery>(), It.IsAny<CancellationToken>()))
                .Returns<GetBookQuery, CancellationToken>(async (q, c) =>
                {
                    bookId = q.BookId;
                    return await Task.FromResult(
                        new BookDto
                        {
                            Id = q.BookId,
                            Title = "Learning C#",
                            Authors = new List<AuthorDto>
                            {
                                new AuthorDto
                                {
                                    Id = 1,
                                    Name = "John Smith"
                                }
                            }
                        });
                });

            var controller = new BookController(_mockMediator.Object);

            await controller.Get(1);

            Assert.AreEqual(bookId, 1);
        }


        [TestMethod]
        public async Task Get_Book_By_Id_ShouldReturnOkStatusCode()
        {
            _mockMediator
                .Setup(m => m.Send(It.IsAny<GetBookQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(
                        new BookDto
                        {
                            Id = 1,
                            Title = "Learning C#",
                            Authors = new List<AuthorDto>
                            {
                                new AuthorDto
                                {
                                    Id = 1,
                                    Name = "John Smith"
                                }
                            }
                        });

            var controller = new BookController(_mockMediator.Object);

            var result = await controller.Get(1);

            var okResult = result.Result as OkObjectResult;

            Assert.AreEqual((int)HttpStatusCode.OK, okResult.StatusCode);
        }

        [TestMethod]
        public async Task Get_Book_By_Id_ShouldReturnFoundBook()
        {
            //Arrange
            var book = new BookDto
            {
                Id = 1,
                Title = "Learning C#",
                Authors = new List<AuthorDto>
                            {
                                new AuthorDto
                                {
                                    Id = 1,
                                    Name = "John Smith"
                                }
                            }
            };
            _mockMediator
                .Setup(m => m.Send(It.IsAny<GetBookQuery>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(book);

            //Act
            var controller = new BookController(_mockMediator.Object);
            var result = await controller.Get(1);

            var okResult = result.Result as OkObjectResult;

            //Assert
            Assert.AreEqual(book, okResult.Value);
        }
        */

    }
}