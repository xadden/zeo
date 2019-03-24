using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeo.Episode {
    public class Episode {
        public string title;
        public string url;

        public Episode(string title, string url) {
            this.title = title;
            this.url = url;
        }

        public override string ToString() {
            return this.title;
        }
    }
}
