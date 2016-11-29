using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdalPipeline.Models;

namespace AdalPipeline.Abstract
{
   public interface IRequestApprovalRepository
    {
        IEnumerable<Request> Requests { get; }
    }
}
