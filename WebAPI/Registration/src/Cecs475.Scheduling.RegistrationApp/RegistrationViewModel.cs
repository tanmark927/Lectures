using Cecs475.Scheduling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cecs475.Scheduling.RegistrationApp
{

    public class SemesterTermDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString() { return Name; }
    }

    public class CourseSectionDto
    {
        public int Id { get; set; }
        public int SemesterTermId { get; set; }
        public CatalogCourse CatalogCourse { get; set; }
        public int SectionNumber { get; set; }

        public override string ToString()
        {
            string idString = string.Format("{0}", Id.ToString().PadLeft(2, '0'));
            return SectionNumber + "-" + idString;
        }
    }

    public class RegistrationViewModel
    {
        /// <summary>
        /// A URL path to the registration web service.
        /// </summary>
        public string ApiUrl { get; set; }
        /// <summary>
        /// The full name of the student who is registering.
        /// </summary>
        public string FullName { get; set; }

        public IEnumerable<SemesterTermDto> StdList { get; set; }
        public IEnumerable<CourseSectionDto> CsdList { get; set; }

    }
}
