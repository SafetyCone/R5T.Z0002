using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using R5T.T0132;


namespace R5T.Z0002
{
    [FunctionalityMarker]
    public partial interface ISyntaxTriviaOperator : IFunctionalityMarker
    {
        public SyntaxTrivia GetEndOfLine(string endOfLineText)
        {
            var output = SyntaxFactory.EndOfLine(endOfLineText);
            return output;
        }

        /// <summary>
        /// Uses the <see cref="Environment.NewLine"/> value.
        /// </summary>
        public SyntaxTrivia GetEndOfLine_Environment()
        {
            var output = this.GetEndOfLine(Environment.NewLine);
            return output;
        }

        /// <summary>
        /// Selects <see cref="GetEndOfLine_Environment"/> as the default.
        /// </summary>
        public SyntaxTrivia GetEndOfLine()
        {
            var output = this.GetEndOfLine_Environment();
            return output;
        }

        /// <summary>
        /// Same as <see cref="GetEndOfLine()"/>.
        /// </summary>
        public SyntaxTrivia GetNewLine()
        {
            var output = this.GetEndOfLine();
            return output;
        }

        public SyntaxTrivia GetWhitespace(string whitespaceText)
        {
            var output = SyntaxFactory.Whitespace(whitespaceText);
            return output;
        }

        public SyntaxTrivia GetTab_AsSpaces()
        {
            var tab = Instances.Strings.Tab_AsSpaces;

            var output = this.GetWhitespace(tab);
            return output;
        }

        public SyntaxTrivia GetTab_AsTab()
        {
            var tab = Instances.Strings.Tab;

            var output = this.GetWhitespace(tab);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetTab_AsSpaces"/> as the default.
        /// </summary>
        public SyntaxTrivia GetTab()
        {
            var output = this.GetTab_AsSpaces();
            return output;
        }
    }
}
