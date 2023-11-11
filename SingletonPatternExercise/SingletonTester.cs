namespace SingletonPatternExercise
{
    public class SingletonTester
    {
        private static Delegate _method;
        private static bool IsFirstTry = true;
        public static bool _IsSingleton(Func<object> func)
        {
            if (IsFirstTry)
            {
                _method = func;
                IsFirstTry = false;
            }
            return _method.Equals(func);
        }

        /*
            If a factory does in fact make a singleton, then any instance created 
            would be referentially equal to any other instance created. So, for example, 
            we can create two instances and check that they refer to the same object. 
            If that's the case, we've got a singleton!
         */
        public static bool IsSingleton(Func<object> func)
        {
            var obj1 = func();
            var obj2 = func();
            return ReferenceEquals(obj1, obj2);
        }
    }
}