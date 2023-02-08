using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppMVVM.Model
{
    public class DownloadModel
    {
        public bool ok { get; set; }
        public DownloadResult result { get; set; }
    }

    public class DownloadResult
    {
        public string download_url { get; set; }
    }

}
