namespace ConditionsLogic
{
    public class SubtractionCondition : ICondition
    {
        //x-y=[-max, +max]
        public string GetVisualizeCondition(int x, int y)
        {
            return x + "-" + y+"="+(x-y);
        }

        public bool Verify(int x, int y, int minValue, int maxValue)
        {
            return x - y <= maxValue && x - y >= minValue;
        }
    }
}