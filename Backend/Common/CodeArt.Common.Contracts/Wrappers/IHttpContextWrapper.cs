using System.Web;

namespace CodeArt.Common.Contracts.Wrappers
{
    public interface IHttpContextWrapper
    {
        HttpContext Current { get; }
    }
}
