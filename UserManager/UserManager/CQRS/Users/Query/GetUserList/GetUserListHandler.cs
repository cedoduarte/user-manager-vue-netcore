using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManager.CQRS.Users.ViewModel;
using UserManager.Models;

namespace UserManager.CQRS.Users.Query.GetUserList
{
    public class GetUserListHandler : IRequestHandler<GetUserListQuery, ActionResult<IEnumerable<UserViewModel>>>
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _dbContext;

        public GetUserListHandler(IMapper mapper, AppDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<ActionResult<IEnumerable<UserViewModel>>> Handle(GetUserListQuery query, CancellationToken cancel)
        {
            try
            {
                if (query.GetAll)
                {
                    return new OkObjectResult(_mapper.Map<IEnumerable<UserViewModel>>(await _dbContext.Users
                        .Where(user => !user.IsDeleted)
                        .ToListAsync(cancel)));
                }
                if (!string.IsNullOrEmpty(query.Keyword))
                {
                    string keyword = query.Keyword.ToLower().Trim();
                    return new OkObjectResult(_mapper.Map<IEnumerable<UserViewModel>>(await _dbContext.Users
                        .Where(user => !user.IsDeleted && (
                            (string.IsNullOrEmpty(user.Id.ToString()) ? false : user.Id.ToString().Contains(keyword))
                            || (string.IsNullOrEmpty(user.FirstName) ? false : user.FirstName.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.LastName) ? false : user.LastName.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.Country) ? false : user.Country.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.Province) ? false : user.Province.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.City) ? false : user.City.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.ZipCode) ? false : user.ZipCode.ToLower().Contains(keyword))
                            || user.Birthdate.ToString().ToLower().Contains(keyword)
                            || (string.IsNullOrEmpty(user.PhoneNumber) ? false : user.PhoneNumber.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.Email) ? false : user.Email.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.Username) ? false : user.Username.ToLower().Contains(keyword))
                            || (string.IsNullOrEmpty(user.LinkedInProfileUrl) ? false : user.LinkedInProfileUrl.ToLower().Contains(keyword))
                            || user.LastModification.ToString().ToLower().Contains(keyword)))
                        .ToListAsync(cancel)));
                }
                throw new Exception("The keyword cannot be empty!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
