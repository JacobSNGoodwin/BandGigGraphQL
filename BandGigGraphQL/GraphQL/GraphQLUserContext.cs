using System.Security.Claims;

namespace BandGigGraphQL.GraphQL
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
