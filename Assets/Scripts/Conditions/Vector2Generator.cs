using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ConditionsLogic
{
    public class Vector2Generator
    {
        private ConditionChecker conditionChecker;

        public Vector2Generator(ICondition[] conditions)
        {
            conditionChecker = new ConditionChecker(conditions);
        }
        
        public List<Vector2Int> Generate(int minValue, int maxValue, int count)
        {
            List<Vector2Int> verifiedVectors = new List<Vector2Int>(); 
            List<int> listNumbers = Utilities.GenerateNonRepeatingNumbers(minValue, maxValue);

            foreach (var elementX in listNumbers)
            {
                foreach (var elementY in listNumbers.Where(elementY => conditionChecker.AllVerify(elementX, elementY, minValue, maxValue)))
                {
                    Debug.Log(new Vector2(elementX, elementY));
                    verifiedVectors.Add(new Vector2Int(elementX, elementY));

                    if (verifiedVectors.Count == count)
                    {
                        return verifiedVectors;
                    }
                }
            }

            return verifiedVectors;
        }
    }
}