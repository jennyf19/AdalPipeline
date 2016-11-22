using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string ReleaseNotes { get; set; }
        //public bool IsApproved { get; set; }
        
    }
}