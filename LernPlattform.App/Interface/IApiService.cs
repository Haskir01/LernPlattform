using LernPlattform.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace LernPlattform.App.Interface
{
    public interface IApiService
    {
        Task<List<BereichDto>> GetBereicheAsync();
        Task<List<KursDto>> GetKursAsync();
    }
}
