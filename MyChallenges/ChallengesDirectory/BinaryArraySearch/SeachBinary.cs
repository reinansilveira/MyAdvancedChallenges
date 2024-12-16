using System.Collections;

namespace MyChallenges.ChallengesDirectory.BinaryArraySearch;

public class SeachBinary
{
    List<int> input = new List<int> { 1, 3, 4,6 ,10, 8, 5, 9, 11 };
    int exit = 7;

    public List<int> AscendingOrder()
    {
        var ascendingOrder = input.OrderBy(e => e).ToList();

        return ascendingOrder;
    }

    public int OrderMin()
    {
        var ascendingOrder = AscendingOrder();
        var listMax = ascendingOrder.Max();
        var listMin = ascendingOrder.Min();

        return listMin;
    }

    public int Ordenation()
    {
        var ascendingOrder = AscendingOrder();
        var listMax = ascendingOrder.Max();
        var listMin = ascendingOrder.Min();
        var value = 0;
        while (listMin <= listMax)
        {
            var divination = (listMax + listMin) / 2;
            if (exit == divination)
            {
                value = divination;
                return value;
            }
            
            if (divination > exit)
            {
                listMax = divination;
            }

            if (divination < exit)
            {
                listMin = divination;
            }
            
        }

        return value;
    } 
    
}