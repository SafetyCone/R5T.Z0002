using System;


namespace R5T.Z0002
{
    public class SyntaxTrivias : ISyntaxTrivias
    {
        #region Infrastructure

        public static ISyntaxTrivias Instance { get; } = new SyntaxTrivias();


        private SyntaxTrivias()
        {
        }

        #endregion
    }
}
