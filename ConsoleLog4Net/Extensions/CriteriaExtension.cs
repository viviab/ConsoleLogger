using System.Collections.Generic;
using System.Linq;
using ConsoleLog4Net.Enums;
using ConsoleLog4Net.Interfaces;
using ConsoleLog4Net.Model;

namespace ConsoleLog4Net.Extensions
{
    public static class CriteriaExtension
    {
        public static T AddCriteria<T>(this T request, SearchCriteriaDto type, string value = "true") where T : ICriteria
        {
            if (value == null)
                return request;

            if (request.Criteria.CriteriaDtos == null)
                request.Criteria.CriteriaDtos = new List<CriteriaDto>();

            var criteria = request.Criteria.CriteriaDtos.ToList();
            criteria.Add(new CriteriaDto()
            {
                CriteriaValue = value,
                CriteriaType = type
            });
            request.Criteria.CriteriaDtos = criteria;
            return request;
        }
    }
}
