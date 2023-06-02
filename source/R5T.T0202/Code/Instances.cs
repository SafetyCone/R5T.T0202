using System;


namespace R5T.T0202
{
    public static class Instances
    {
        public static Extensions.IIntegerOperator IntegerOperator_Extensions => Extensions.IntegerOperator.Instance;
        public static Extensions.IStringOperator StringOperator_Extensions => Extensions.StringOperator.Instance;
    }
}