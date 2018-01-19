using Domain.Services;
using System;
using System.Net;
using System.Net.Sockets;

namespace Service   
{
    public class ValidationContaService : IValidationContaService
    {
        public bool ValidationDominioEmail(string email) 
        {
            
            int prefixo = email.IndexOf("@")+1;
            int sufixo = email.Length - prefixo;
            var dominio = "www."+email.Substring(prefixo, sufixo);
            var result = IsConectedToInternet(dominio);

            return result;
        }

        // Testa se um URL esta ativa. Ex: bool res = IsConnectedToHost(new Uri("www.teste.com.br/etc"))
        public static bool IsConectedToHost(Uri uri)
        {
            try
            {
                Dns.GetHostEntry(uri.Host);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        // Testa se existe conexão do dominio com a internet;
        public static bool IsConectedToInternet(string email)
        {
            try
            {
                Dns.GetHostEntry(email);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

