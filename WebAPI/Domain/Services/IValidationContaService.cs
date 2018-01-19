using System;
    
namespace Domain.Services
{
    public interface IValidationContaService : IDisposable
    {
        bool ValidationDominioEmail(string email);   
    }
}
