using System;


namespace R5T.Z0002
{
    public class SyntaxTriviaOperator : ISyntaxTriviaOperator
    {
        #region Infrastructure

        public static ISyntaxTriviaOperator Instance { get; } = new SyntaxTriviaOperator();


        private SyntaxTriviaOperator()
        {
        }

        #endregion
    }
}
