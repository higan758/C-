
namespace NullCheckExample
{
   public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            string ternaryResult = (username == null) ? "Username is not available" : username;
            Console.WriteLine($"Ternary Operator result : {ternaryResult}");

            string null_CoalesingOperator = username ?? "Username is not availabel";
            Console.WriteLine($"Null-Coalesing Operator result : {null_CoalesingOperator}");

            username ??= "DefaultUser";
            Console.WriteLine("After Null-Coalescing Assignment: " + username);
        }

    }
}
