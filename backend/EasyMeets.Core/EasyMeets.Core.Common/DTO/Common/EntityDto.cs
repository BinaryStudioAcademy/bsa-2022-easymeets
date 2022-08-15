using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMeets.Core.Common.DTO.Common
{
    public abstract class EntityDto<T> where T : struct
    {
        public T Id { get; set; }
    }
}
