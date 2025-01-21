using ActionResultsTutorial.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActionResultsTutorial.TagHelpers
{

    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        public List<Employee> employees;

        public EmployeeListTagHelper()
        {
            employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Firstname = "Tural",
                    Lastname = "Huseynli",
                    CityId = 1,
                },
                new Employee()
                {
                    Id=2,
                    Firstname="Mehemmed",
                    Lastname = "Humbetli",
                    CityId = 2,
                },
                 new Employee()
                {
                    Id=3,
                    Firstname="Veli",
                    Lastname = "Kerimli",
                    CityId = 3,
                },
                        new Employee()
                {
                    Id=2,
                    Firstname="Amin",
                    Lastname = "Humbetli",
                    CityId = 2,
                },
                 new Employee()
                {
                    Id=3,
                    Firstname="Mirze",
                    Lastname = "Kerimli",
                    CityId = 3,
                },
                     new Employee()
                {
                    Id=3,
                    Firstname="Kamal",
                    Lastname = "Kerimli",
                    CityId = 3,
                },

            };
        }

        private const string ListCountAttribute = "MehemmedinCountu";

        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            var query = employees.Take(ListCount);
            StringBuilder sb = new();
            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href ='employee/detail/{0}'>{1}</a></h2>" , item.Id , item.Firstname);
            }
            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
