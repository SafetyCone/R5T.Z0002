using System;

using Microsoft.CodeAnalysis;

using R5T.T0132;


namespace R5T.Z0002
{
    [FunctionalityMarker]
    public partial interface IIndentationOperator : IFunctionalityMarker
    {
        public SyntaxTriviaList GetByTabCount(int tabCount)
        {
            var output = Instances.SyntaxTriviaListOperator.GetByTabCount(tabCount);
            return output;
        }

        public SyntaxTriviaList GetClassIndentation()
        {
            var output = this.GetByTabCount(
                Instances.TabCounts.ClassDeclarationTabCount);

            return output;
        }
    }
}
