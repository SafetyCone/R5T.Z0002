using System;

using Microsoft.CodeAnalysis;

using R5T.T0131;


namespace R5T.Z0002
{
    [ValuesMarker]
    public partial interface ISyntaxTrivias : IValuesMarker
    {
        /// <summary>
        /// The values <see cref="EndOfLine"/> and <see cref="NewLine"/> are the same.
        /// </summary>
        public SyntaxTrivia EndOfLine => Instances.SyntaxTriviaOperator.GetEndOfLine();

        /// <summary>
        /// The values <see cref="NewLine"/> and <see cref="EndOfLine"/> are the same.
        /// </summary>
        public SyntaxTrivia NewLine => Instances.SyntaxTriviaOperator.GetNewLine();

        /// <summary>
        /// Returns a tab as four (4) spaces.
        /// </summary>
        public SyntaxTrivia Tab => Instances.SyntaxTriviaOperator.GetTab();
    }
}
