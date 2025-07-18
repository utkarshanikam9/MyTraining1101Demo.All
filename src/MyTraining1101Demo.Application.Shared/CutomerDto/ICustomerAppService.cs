using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTraining1101Demo.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1101Demo.CutomerDto
{
    public interface ICustomerAppService : IApplicationService
    {
        Task CreateOrEditAsync(CreateOrEditCustomerDto input);
        Task CreateAsync(CreateOrEditCustomerDto input);
        //Task UpdateAsync(CreateOrEditCustomerDto input);
        //Task EditPerson(EditCustomer input);
        Task DeleteAsync(EntityDto input);
        Task<ListResultDto<CustomerListDto>> GetAllAsync(GetCustomerInputDto input);
    }
}
