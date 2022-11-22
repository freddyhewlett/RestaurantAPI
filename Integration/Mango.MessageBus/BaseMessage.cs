using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.MessageBus
{
    public class BaseMessage
    {
        public Guid Id { get; set; }
        public DateTime MessageCreated { get; set; }

        public BaseMessage()
        {
            Id = Guid.NewGuid();
            MessageCreated = DateTime.Now;
        }
    }
}
