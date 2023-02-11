using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.CodeAnalysis;

using R5T.T0132;


namespace R5T.Z0002
{
    [FunctionalityMarker]
    public partial interface ISyntaxTriviaListOperator : IFunctionalityMarker
    {
        public SyntaxTriviaList From(
            IEnumerable<SyntaxTrivia> syntaxTrivias)
        {
            var output = this.GetNew()
                .AddRange(syntaxTrivias)
                ;

            return output;
        }

        public SyntaxTriviaList From(
            params SyntaxTrivia[] syntaxTrivias)
        {
            var output = this.From(syntaxTrivias.AsEnumerable());
            return output;
        }

        /// <summary>
        /// A blank line is two consecutive new line syntax trivias.
        /// </summary>
        public SyntaxTriviaList GetBlankLine()
        {
            var newLine = Instances.SyntaxTrivias.NewLine;

            var output = this.From(
                Instances.EnumerableOperator.Repeat(newLine, 2));

            return output;
        }

        /// <summary>
        /// Two blank lines are created by three consecutive new line syntax trivias.
        /// </summary>
        public SyntaxTriviaList GetBlankLines_Two()
        {
            var newLine = Instances.SyntaxTrivias.NewLine;

            var output = this.From(
                Instances.EnumerableOperator.Repeat(newLine, 3));

            return output;
        }

        public SyntaxTriviaList GetByTabCount(int tabCount)
        {
            var tab = Instances.SyntaxTrivias.Tab;

            var output = this.From(
                Instances.EnumerableOperator.Repeat(tab, tabCount));

            return output;
        }

        public SyntaxTriviaList GetNew()
        {
            var output = new SyntaxTriviaList();
            return output;
        }

        public SyntaxTriviaList GetNewLine()
        {
            var output = this.From(
                Instances.SyntaxTrivias.NewLine)
                ;

            return output;
        }
    }
}
