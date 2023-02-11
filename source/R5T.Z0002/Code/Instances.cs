using System;


namespace R5T.Z0002
{
    public static class Instances
    {
        public static F0000.IEnumerableOperator EnumerableOperator => F0000.EnumerableOperator.Instance;
        public static IIndentationOperator IndentationOperator => Z0002.IndentationOperator.Instance; 
        public static F0000.IStrings Strings => F0000.Strings.Instance;
        public static F0000.IStringOperator StringOperator => F0000.StringOperator.Instance;
        public static ISyntaxTriviaListOperator SyntaxTriviaListOperator => Z0002.SyntaxTriviaListOperator.Instance;
        public static ISyntaxTriviaOperator SyntaxTriviaOperator => Z0002.SyntaxTriviaOperator.Instance;
        public static ISyntaxTrivias SyntaxTrivias => Z0002.SyntaxTrivias.Instance;
        public static ITabCounts TabCounts => Z0002.TabCounts.Instance;
    }
}
