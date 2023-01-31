namespace ConditionsLogic
{
    public interface ICondition
    {
        public string GetVisualizeCondition(int x, int y);
        public bool Verify(int x, int y, int minValue, int maxValue);
    }
}
