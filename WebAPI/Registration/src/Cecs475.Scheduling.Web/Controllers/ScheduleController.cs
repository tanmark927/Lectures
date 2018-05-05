using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cecs475.Scheduling.Web.Controllers
{ 
    public class SemesterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static SemesterDto From(Model.SemesterTerm st)
        {
            return new SemesterDto()
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

        //[HttpGet]
        //[Route("{year}/{term}")]
        //public IEnumerable<CourseSectionDto> GetSections(string year, string terms)
        //{
        //    string termname = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(terms.ToLower()) + " " + year;
        //    Model.SemesterTerm term = mContext.SemesterTerms.Where(
        //        t => t.Name == termname).SingleOrDefault();

        //    if (term == null)
        //    {
        //        throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound,
        //        $"Semester name \"{termname}\" not found"));
        //    }

        //    //return list of CourseSectionDto objects with given semesterid
        //    return mContext.SemesterTerms.Select(CourseSectionDto.From);
        //}

        //[HttpGet]
        //[Route("{id:int}")]
        //public IEnumerable<CourseSectionDto> GetSections(int id)
        //{
        //    Model.SemesterTerm term = mContext.SemesterTerms.Where(
        //        t => t.Id == id).SingleOrDefault();
        //    if (term == null)
        //    {
        //        throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.NotFound,
        //        $"Semester name \"{id}\" not found"));
        //    }

        //    //return list of CourseSectionDto objects offered in semester
        //    return mContext.CourseSections.Select(CourseSectionDto.From);
        //}

        [HttpGet]
        [Route("terms")]
        public IEnumerable<SemesterDto> GetTerms()
        {
            return mContext.SemesterTerms.Select(SemesterDto.From);
        }
    }
}