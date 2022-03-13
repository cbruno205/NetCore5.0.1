using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.BusinessService.Interfaces
{
    public interface ILoginBusinessService
    {
        string Authentication(User user);
    }
}