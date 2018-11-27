using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC_SocialNetwork.Campaigns
{
    class Campaign
    {
        private string name;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        private string description;
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public Campaign(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
