using System.Collections.Generic;
using ConditionsLogic;
using TMPro;
using UnityEngine;

public class ConditionsDisplayer : MonoBehaviour
{
    [SerializeField] private TMP_InputField maxRangeInputField;
    [SerializeField] private TMP_Text answersTxt;

    private Vector2Generator generator;
    private ICondition[] conditions;

    private void Start()
    {
        conditions = new ICondition[]
            {new AdditionCondition(), new SubtractionCondition(), new GreaterThanOrEqualCondition()};
        generator = new Vector2Generator(conditions);
    }

    public void GenerateVectors(int count)
    {
        bool success = int.TryParse(maxRangeInputField.text, out var max);

        if (success)
        {
            List<Vector2Int> vector2Elements = generator.Generate(-max, max, count);
            answersTxt.text = Utilities.DisplayVectorsByConditions(vector2Elements, conditions);
        }
        else
        {
            answersTxt.text = "!";
        }
    }
}