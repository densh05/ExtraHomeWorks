using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    struct MyTask
    {
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; } 
        public string Description { get; set; }
        public ProgressType Status { get; set; }

        public MyTask()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }

        
    }
}
