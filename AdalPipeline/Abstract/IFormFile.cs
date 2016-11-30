using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdalPipeline.Abstract
{
    public interface IFormFile
    {
        string ReleaseTitle { get; }
        string ReleaseVersion { get; }

        [DataType(DataType.MultilineText)]
        string RelaseNotes { get; }

        Stream OpenReadStream();
        void CopyTo(Stream target);
        Task CopyToAsync(Stream target);
    }
}
