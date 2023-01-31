using System;
using System.Collections.Generic;
using System.Linq;
using ConditionsLogic;
using UnityEngine;
using Random = System.Random;

public static class Utilities
{
    public static List<int> GenerateNonRepeatingNumbers(int minValue, int maxValue)
    {
        Random rand = new Random();

        int count = Math.Abs(minValue) + Math.Abs(maxValue) + 1;

        List<int> possible = Enumerable.Range(minValue, count).ToList();
        List<int> listNumbers = new List<int>();

        for (int i = 0; i < count; i++)
        {
            int index = rand.Next(0, possible.Count);
            listNumbers.Add(possible[index]);
            possible.RemoveAt(index);
        }

        return listNumbers;
    }
    
    public static void Shuffle<T>(this IList<T> list, Random random)
    {
        int count = list.Count;
        int last = count - 1;
            
        for (int i = 0; i < last; ++i)
        {
            int randomIndex = random.Next(i, count);
            (list[i], list[randomIndex]) = (list[randomIndex], list[i]);
        }
    }
    
    public static string DisplayVectorsByConditions(IEnumerable<Vector2Int> vectors, IEnumerable<ICondition> conditions)
    {
        string conditionsText= "";
        
        foreach (var vector in vectors)
        {
            foreach (var condition in conditions)
            {
                conditionsText += condition.GetVisualizeCondition(vector.x, vector.y)+"\n";
            }

            conditionsText += "\n";
        }

        return conditionsText;
    } 
}