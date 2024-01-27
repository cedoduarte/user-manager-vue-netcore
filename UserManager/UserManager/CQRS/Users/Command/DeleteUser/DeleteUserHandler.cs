using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;

namespace UserManager.CQRS.Users.Command.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, ActionResult<UserViewModel>>
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public DeleteUserHandler(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<ActionResult<UserViewModel>> Handle(DeleteUserCommand command, CancellationToken cancel)
        {
            try
            {
                User selectedUser = await CheckExistance(command, cancel);
                await UpdateRecord(selectedUser, cancel);
                UserViewModel updatedUser = _mapper.Map<UserViewModel>(selectedUser);
                return new OkObjectResult(updatedUser);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task<bool> UpdateRecord(User selectedUser, CancellationToken cancel)
        {
            selectedUser.IsDeleted = true;
            selectedUser.LastModification = DateTime.Now;
            _dbContext.Users.Update(selectedUser);
            await _dbContext.SaveChangesAsync(cancel);
            return true;
        }

        private async Task<User> CheckExistance(DeleteUserCommand command, CancellationToken cancel)
        {
            User selectedUser = await _dbContext.Users
                    .Where(user => user.Id == command.Id && !user.IsDeleted)
                    .FirstOrDefaultAsync(cancel);
            if (selectedUser is null)
            {
                throw new Exception($"{nameof(User)} with ID {command.Id} does not exist!");
            }
            return selectedUser;
        }
    }
}
