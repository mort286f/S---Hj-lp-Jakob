using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S___Hjælp_Jakob
{
    //This interface contains all the fields a message has
    public interface IMessage
    {
        string To { get; set; }
        string From { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }
        string Cc { get; set; }
    }
}
