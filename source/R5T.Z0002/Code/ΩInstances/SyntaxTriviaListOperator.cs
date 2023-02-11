using System;


namespace R5T.Z0002
{
    public class SyntaxTriviaListOperator : ISyntaxTriviaListOperator
    {
        #region Infrastructure

        public static ISyntaxTriviaListOperator Instance { get; } = new SyntaxTriviaListOperator();


        private SyntaxTriviaListOperator()
        {
        }

        #endregion
    }
}
