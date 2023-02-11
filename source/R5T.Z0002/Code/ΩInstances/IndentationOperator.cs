using System;


namespace R5T.Z0002
{
    public class IndentationOperator : IIndentationOperator
    {
        #region Infrastructure

        public static IIndentationOperator Instance { get; } = new IndentationOperator();


        private IndentationOperator()
        {
        }

        #endregion
    }
}
