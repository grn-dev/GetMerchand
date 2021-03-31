using GetMerchant.Entity;
using System.Threading.Tasks;

namespace GetMerchant
{
    public interface IMerchant
    {
        string BaseUrl { get; set; } 

        Task<ReadRequestCartableResponse> ReadRequestCartable(ShaparakReadRequest model);

        Task<ShaparakWriteResponse> WriteExternalRequest(ShaparakWriteRequest model);
    }
}
