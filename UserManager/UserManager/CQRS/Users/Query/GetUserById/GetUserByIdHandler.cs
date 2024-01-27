using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;

namespace UserManager.CQRS.Users.Query.GetUserById
{
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, ActionResult<UserViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetUserByIdHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<ActionResult<UserViewModel>> Handle(GetUserByIdQuery query, CancellationToken cancel)
        {
            try
            {
                User requestedUser = await _dbContext.Users
                    .Where(user => !user.IsDeleted && user.Id == query.Id)
                    .FirstOrDefaultAsync(cancel);
                if (requestedUser is null)
                {
                    throw new Exception($"{nameof(User)} with ID {query.Id} does not exist!");
                }
                return new OkObjectResult(_mapper.Map<UserViewModel>(requestedUser));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
