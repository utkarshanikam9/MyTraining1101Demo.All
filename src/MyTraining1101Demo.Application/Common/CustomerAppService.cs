using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyTraining1101Demo.Customer;
using MyTraining1101Demo.CutomerDto;
using MyTraining1101Demo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1101Demo.Common
{
    public class CustomerAppService : MyTraining1101DemoAppServiceBase, ICustomerAppService
    {
        private readonly IRepository<CustomerEntity> _customerRepository;
        private readonly IRepository<CustomerUser> _customerUserRepository;


        public CustomerAppService(IRepository<CustomerEntity> customerRepository, IRepository<CustomerUser> customerUserRepository)
        {
            _customerRepository = customerRepository;
            _customerUserRepository = customerUserRepository;
        }

        public async Task CreateOrEditAsync(CreateOrEditCustomerDto input)
        {
            if (input.Id.HasValue)
            {
                //await UpdateAsync(input);
            }
            else
            {
                await CreateAsync(input);
            }
        }

        public async Task CreateAsync(CreateOrEditCustomerDto input)
        {
            try
            {
                var customer = ObjectMapper.Map<CustomerEntity>(input);
                await _customerRepository.InsertAsync(customer);
            }
            catch (Exception ex)
            {
                Logger.Error("Error in CustomerAppService.CreateAsync", ex);
                throw;
            }
        }

        //public async Task UpdateAsync (CreateOrEditCustomerDto input)
        //{
        //    var customer = await _customerRepository.GetAsync(input.Id.Value);
        //    return ObjectMapper.Map<CreateOrEditCustomerDto>(customer);
        ////}

        public async Task DeleteAsync(EntityDto input)
        {
            await _customerRepository.DeleteAsync(input.Id);
        }

        public async Task<ListResultDto<CustomerListDto>> GetAllAsync(GetCustomerInputDto input)
        {
            //var customers = await _customerRepository.GetAllIncluding(x => x.User).ToListAsync();
            //return new ListResultDto<CustomerListDto>(
            //    ObjectMapper.Map<List<CustomerListDto>>(customers)
            //);

            var customer = _customerRepository
               .GetAllIncluding(x => x.User)
               .WhereIf(
                   !input.Filter.IsNullOrEmpty(),
                   p => p.Name.Contains(input.Filter) ||
                           p.Address.Contains(input.Filter) ||
                           p.EmailId.Contains(input.Filter)
               )
               .OrderBy(p => p.Name)
               .ThenBy(p => p.EmailId)
               .ToList();

            return new ListResultDto<CustomerListDto>(ObjectMapper.Map<List<CustomerListDto>>(customer));

        }

        public async Task<ListResultDto<UserLookupDto>> GetAvailableUsers()
        {
            // Get all user IDs that are already assigned
            var assignedUserIds = await _customerRepository.GetAll()
                .Select(c => c.UserId)
                .ToListAsync();

            // Get users who are NOT assigned
            var users = await UserManager.Users
                .Where(u => !assignedUserIds.Contains(u.Id))
                .ToListAsync();

            var userDtos = users.Select(u => new UserLookupDto
            {
                Id = u.Id,
                Name = u.Name ?? u.Surname
            }).ToList();

            return new ListResultDto<UserLookupDto>(userDtos);
        }

        public async Task<EditCustomerOutput> GetCustomerForEdit(EditCustomerInputDto input)
        {
            var customer = await _customerRepository.GetAsync(input.Id);
            return ObjectMapper.Map<EditCustomerOutput>(customer);
        }

        public async Task EditCustomer(EditCustomer input)
        {
            var customer = await _customerRepository.GetAsync(input.Id);
            customer.Name = input.Name;
            customer.Address = input.Address;
            customer.EmailId = input.EmailId;
            customer.RegistrationDate = input.RegistrationDate;
            customer.UserId = input.UserId;
            await _customerRepository.UpdateAsync(customer);
        }


    }
}
