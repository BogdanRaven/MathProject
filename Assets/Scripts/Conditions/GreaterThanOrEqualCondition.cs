namespace ConditionsLogic
{
    public class GreaterThanOrEqualCondition : ICondition
    {
        //x>=y
        public string GetVisualizeCondition(int x, int y)
        {
            return x + ">=" + y;
        }

        public bool Verify(int x, int y, int minValue, int maxValue)
        {
            return x >= y;
        }
    }
}