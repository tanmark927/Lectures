using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cecs475.Scheduling.Web.Controllers
{ 
    public class SemesterTermDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static SemesterTermDto From(Model.SemesterTerm st)
        {
            return new SemesterTermDto()
            {
                Id = st.Id,
                Name = st.Name,
            };
        }
    }

    [RoutePrefix("api/schedule")]
    public class ScheduleController: ApiController
    {
        private Model.CatalogContext mContext = new Model.CatalogContext();

        [HttpGet]
        [Route("{year}/{terms}")]
        public IEnumerable<CourseSectionDto> GetSections(string year, string terms)
        {
            string termname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(terms.ToLower()) + " " + year;
            Model.SemesterTerm term = mContext.SemesterTerms.Where(t => t.Name == termname).SingleOrDefault();
            if (term == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound, 
                    $"Semester name \"{termname}\" not found"));
            }

            return term.CourseSections.Where(cs => cs.Semester == term).Select(CourseSectionDto.From);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IEnumerable<CourseSectionDto> GetSections(int id)
        {
            Model.SemesterTerm term = mContext.SemesterTerms.Where(
                t => t.Id == id).SingleOrDefault();
            if (term == null)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    $"Semester name \"{id}\" not found"));
            }

            return term.CourseSections.Where(cs => cs.Semester == term).Select(CourseSectionDto.From);
        }

        [HttpGet]
        [Route("terms")]
        public IEnumerable<SemesterTermDto> GetTerms()
        {
            return mContext.SemesterTerms.Select(SemesterTermDto.From);
        }
    }
}