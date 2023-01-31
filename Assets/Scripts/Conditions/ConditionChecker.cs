namespace ConditionsLogic
{
    public class ConditionChecker
    {
        private ICondition[] conditions;

        public ConditionChecker(ICondition[] conditions)
        {
            this.conditions = conditions;
        }

        public bool AllVerify(int x, int y, int minValue, int maxValue)
        {
            foreach (var condition in conditions)
            {
                if (condition.Verify(x, y, minValue, maxValue) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}