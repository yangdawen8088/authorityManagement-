
using Admin.Core.Common.Input;
using Admin.Core.Service.Admin.Api.Input;
using Admin.Core.Common.Output;
using Admin.Core.Model.Admin;
using System.Threading.Tasks;

namespace Admin.Core.Service.Admin.Api
{
    /// <summary>
    /// �ӿڷ���
    /// </summary>	
    public interface IApiService
    {
        /// <summary>
        /// ���һ����¼
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResponseOutput> GetAsync(long id);

        /// <summary>
        /// ����б�
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<IResponseOutput> ListAsync(string key);

        /// <summary>
        /// ��÷�ҳ
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<IResponseOutput> PageAsync(PageInput<ApiEntity> model);

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IResponseOutput> AddAsync(ApiAddInput input);

        /// <summary>
        /// �޸�
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IResponseOutput> UpdateAsync(ApiUpdateInput input);

        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResponseOutput> DeleteAsync(long id);

        /// <summary>
        /// ��ɾ��
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IResponseOutput> SoftDeleteAsync(long id);

        /// <summary>
        /// ������ɾ��
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<IResponseOutput> BatchSoftDeleteAsync(long[] ids);

        /// <summary>
        /// ͬ��
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IResponseOutput> SyncAsync(ApiSyncInput input);
    }
}
