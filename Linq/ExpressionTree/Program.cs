using System.Linq.Expressions;

namespace ExpressionTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Expression<Func<int, bool>> IsNegativeExpression = x => x < 0;
           ParameterExpression parameter = IsNegativeExpression.Parameters[0];
            BinaryExpression binaryExpression = (BinaryExpression)IsNegativeExpression.Body;
            ParameterExpression left = (ParameterExpression)binaryExpression.Left;
            ConstantExpression right = (ConstantExpression)binaryExpression.Right;
            Console.WriteLine($"{parameter.Name} => {left.Name} {binaryExpression.NodeType} {right.Value}");

            // x => x % 2 == 0
            ParameterExpression parameter2 = Expression.Parameter(typeof(int), "x");
            ConstantExpression constant2 = Expression.Constant(0, typeof(int));
            ConstantExpression constant = Expression.Constant(2, typeof(int));
            BinaryExpression binaryExpression2 = Expression.Modulo(parameter2, constant); ;
            BinaryExpression binaryExpression3 = Expression.Equal(binaryExpression2, constant2);
            Expression<Func<int, bool>> IsEvenExpression = Expression.Lambda<Func<int, bool>>(binaryExpression3, new ParameterExpression[] { parameter2 });
            var isEven = IsEvenExpression.Compile();
            Console.WriteLine(isEven(4)); // True
            Console.WriteLine(isEven(5)); // False


        }
    }
}
