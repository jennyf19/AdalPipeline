using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace AdalPipeline.Models
{
    [DisplayName("Request Form:")]
    public class Request
    {
        public string AuthorName { get; set; }
        public string ReleaseTitle { get; set; }
        public string ReleaseVersion { get; set; }

        [DataType(DataType.MultilineText)]
        public string ReleaseNotes { get; set; }

    }
}