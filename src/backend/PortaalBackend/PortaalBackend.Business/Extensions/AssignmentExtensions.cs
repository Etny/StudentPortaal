

using PortaalBackend.Business.Extensions.Models;
using PortaalBackend.Domain.Models;

namespace PortaalBackend.Business.Extensions {

    public static class AssignmentExtensions {

        public static List<Assignment> FilterAndSort(this List<Assignment> self, AssignmentFilterOptions options) 
        {
            string query = options.SearchQuery.ToLower();

            return self.Where(
                assignment => 
                    assignment.Title.ToLower().Contains(query) ||
                    assignment.Description.ToLower().Contains(query)
            ).ToList();
        }

    }
}