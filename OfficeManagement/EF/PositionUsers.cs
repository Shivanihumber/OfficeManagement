using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.EF
{
    [Table("PositionUsers")]
    public class PositionUser
    {
        
        public int PositionId { get; set; }

        public int Id { get; set; }

    }
}
