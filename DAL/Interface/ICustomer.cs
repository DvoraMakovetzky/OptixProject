using DAL.Dtos;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ICustomer
    {
        Task<bool> CreateCustomer(CustomerDto c);
        Task<bool> DeleteCustomer(long id);
        Task<bool> UpdateCustomer(long id,CustomerDto c);
        Task<Customer> GetCustomer(long id);
        //Task<List<CustomerDto>> GetAll();
    }
}
