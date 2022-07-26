using System.Collections.Generic;

namespace Sandwich.interfaces
{
    public interface Parser
    {
        List<Sandwich> Parse(List<Sandwich> sandwiches);
    }
}