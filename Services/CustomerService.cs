using Demo2Grpc.Database;
using Demo2Grpc.Protos;
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using static Demo2Grpc.Protos.GrpcCustomer;

namespace Demo2Grpc.Services
{
    public class CustomerService : GrpcCustomerBase
    {
        public readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public override Task<CustomerList> GetAll(Demo2Grpc.Protos.Empty requestData, ServerCallContext context)
        {
            CustomerList response = new CustomerList();
            var customerlist = _context.Customers.Select(c => new Customer()
            {
                Id = c.Id,
                Name = c.Name,
                Address = c.Address
            });

            response.Customers.AddRange(customerlist);
            return Task.FromResult(response);
        }

        public override Task<Demo2Grpc.Protos.Customer> GetCustomer(IDRequest request, ServerCallContext context)
        {
            var obj = _context.Customers.FirstOrDefault(c => c.Id == request.Id);
            Demo2Grpc.Protos.Customer cus = new Demo2Grpc.Protos.Customer()
            {
                Id = obj.Id,
                Name = obj.Name,
                Address = obj.Address
            };

            return Task.FromResult(cus);
        }

        [HttpPost]
        public override Task<Empty> AddCustomer(Customer request, ServerCallContext context)
        {
            Demo2Grpc.Models.Customer cus = new Demo2Grpc.Models.Customer()
            {
                Id = request.Id,
                Name = request.Name,
                Address = request.Address

            };
            _context.Customers.Add(cus);
            _context.SaveChanges();
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> UpdateCustomer(Customer request, ServerCallContext context)
        {

            Demo2Grpc.Models.Customer cus = new Demo2Grpc.Models.Customer()
            {
                Id = request.Id,
                Name = request.Name,
                Address = request.Address

            };
            _context.Customers.Update(cus);
            _context.SaveChanges();
            return Task.FromResult(new Empty());
        }

        public override Task<Empty> DeleteCustomer(IDRequest request, ServerCallContext context)
        {
            var cus = _context.Customers.Find(request.Id);
            _context.Customers.Remove(cus);
            _context.SaveChanges();
            return Task.FromResult(new Empty());
        }
    }
}
