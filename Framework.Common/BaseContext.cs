using Framework.HTTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Common
{
    public class BaseContext : IBaseContext
    {
        public int FirstNumber { get; set; }
        public int LastNumber { get; set; }

        public IList<IRequest> Requests { get; set; }
        public IList<IResponse> Responses { get; set; }

        public BaseContext(IRequest request, IResponse response)
        {
            this.Requests = new List<IRequest>();
            this.Requests.Add(request);

            this.Responses = new List<IResponse>();
            this.Responses.Add(response);
        }

    }
}
