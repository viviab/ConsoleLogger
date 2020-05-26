using System.Collections.Generic;
using ConsoleLog4Net.Enums;

namespace ConsoleLog4Net.Model
{
    public class CriteriasListDto
    {
        public IEnumerable<CriteriaDto> CriteriaDtos { get; set; }

        public SearchCriteriaDto SortBy { get; set; }

        public bool SortDescending { get; set; }

    }
}
