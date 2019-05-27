using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OfficeManagement.EF
{
    [Table("Position")]
    public class Position
    {
        public int PositionId { get; set; }

        public string PositionName { get; set; }

        public int PositionSuperId { get; set; }

    }
}
