using System.ComponentModel.DataAnnotations.Schema;
using MySqlX.XDevAPI.Relational;
using Remotion.Linq.Clauses;

namespace Vidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        [Column(Order = 1)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public Customer Customer { get; set; }

        public static readonly int Unknown = 0;
        public static readonly int PayAsYouGo = 1;

    }
}