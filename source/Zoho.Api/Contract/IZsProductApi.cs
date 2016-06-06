﻿namespace Teference.Zoho.Api
{
    #region Namespace

    using System.Threading.Tasks;

    #endregion

    public interface IZsProductApi
    {
        Task<ZsProduct> GetAsync(string id);
        Task<ZsProduct> GetAsync(string authToken, string organizationId, string id);

        Task<ZsProducts> GetAllAsync();
        Task<ZsProducts> GetAllAsync(string authToken, string organizationId);

        Task<ZsProduct> CreateAsync(ZsProductInput createInput);
        Task<ZsProduct> CreateAsync(string authToken, string organizationId, ZsProductInput createInput);

        Task<ZsProduct> UpdateAsync(string id, ZsProductInput updateInput);
        Task<ZsProduct> UpdateAsync(string authToken, string organizationId, string id, ZsProductInput updateInput);

        Task<bool> DeleteAsync(string id);
        Task<bool> DeleteAsync(string authToken, string organizationId, string id);

        Task<bool> ActivateAsync(string id);
        Task<bool> ActivateAsync(string authToken, string organizationId, string id);

        Task<bool> DeactivateAsync(string id);
        Task<bool> DeactivateAsync(string authToken, string organizationId, string id);
    }
}