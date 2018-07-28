using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerTableWatch
{
    public class SmsOutboxWatch : TableWatch<SmsOutbox>
    {
        public SmsOutboxWatch() : base(ConfigurationManager.ConnectionStrings["DbOutbox"].ConnectionString)
        {
        }
    }
}
