using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_Aline.Model
{
    public class VideoModel
    {
        private string id;

        public string Id
        {
            get { return id; }
        }

        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; id = value.Split('=')[1]; }
        }

        public VideoModel()
        {

        }
    }
}
