using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    struct MyTask
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Description { get; set; }
        public ProgressType Status { get; set; }
    }
}
