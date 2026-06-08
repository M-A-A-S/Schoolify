using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolify.Common.Models
{
    public class Classroom : BaseEntity
    {
        public int RoomTypeId { get; set; }
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public int Capacity { get; set; }

        public ClassroomType RoomType { get; set; }
        public ICollection<ClassSchedule> ClassSchedules { get; set; }
    }
}
