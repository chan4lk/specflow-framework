using Framework.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework
{
    public interface IBaseContext
    {
        int FirstNumber { get; set; }
        int LastNumber { get; set; }

        IList<IRequest> Requests { get; set; }
        IList<IResponse> Responses { get; set; }
    }
}
