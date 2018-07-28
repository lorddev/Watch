using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerTableWatch
{
    public class SmsOutbox
    {
        public long Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Sms { get; set; }
        public DateTime? RequestDateTimeUtc { get; set; }
        public DateTime? SentDateTimeUtc { get; set; }
    }
}
