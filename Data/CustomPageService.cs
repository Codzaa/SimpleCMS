using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cms.Data
{
    public class CustomPageService
    {
        #region Property
        private readonly AppDBContext _appDBContext;
        #endregion

        #region Constructor
        public CustomPageService(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }
        #endregion

        #region Get List of CustomPages
        public async Task<List<CustomPage>> GetAllCustomPagesAsync()
        {
            return await _appDBContext.CustomPages.ToListAsync();
        }
        #endregion

        #region Insert CustomPage
        public async Task<bool> InsertCustomPageAsync(CustomPage CustomPage)
        {
            await _appDBContext.CustomPages.AddAsync(CustomPage);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region Get CustomPage by Id
        public async Task<CustomPage> GetCustomPageAsync(int Id)
        {
            CustomPage CustomPage = await _appDBContext.CustomPages.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return CustomPage;
        }
        #endregion

        #region Update CustomPage
        public async Task<bool> UpdateCustomPageAsync(CustomPage CustomPage)
        {
             _appDBContext.CustomPages.Update(CustomPage);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion

        #region DeleteCustomPage
        public async Task<bool> DeleteCustomPageAsync(CustomPage CustomPage)
        {
            _appDBContext.Remove(CustomPage);
            await _appDBContext.SaveChangesAsync();
            return true;
        }
        #endregion
    }
}