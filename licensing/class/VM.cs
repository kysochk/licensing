using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licensing
{
    public class VM
    {
        public List<Players> play;
        public List<Coach> co;
        public List<Team> tea;
        public List<Region> reg;
        public VM()
        {
            play = BaseConnect.BaseModel.Players.ToList();
        }
       
        public Players gid;
        public Players getidP
        {
            get
            {
                return gid;
            }
            set
            {
                gid = value;
            }
        }

       
    }
}
