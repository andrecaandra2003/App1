using App1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App1.Services
{
    public interface IPacientiServices
    {
        Task<List<PacientiModels>> GetPacientiList();
        Task<bool> AddPacienti(PacientiModels pacient);
        Task<bool> DeletePacienti(PacientiModels pacient);
        Task<bool> UpdatePacienti(PacientiModels pacient);
    }
}
