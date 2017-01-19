using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    class ChangeTaskStatusCommand : ICommand 
    {
        public string TaskId { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
    
}
