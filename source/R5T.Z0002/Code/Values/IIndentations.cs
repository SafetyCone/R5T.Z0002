using System;

using Microsoft.CodeAnalysis;

using R5T.T0131;


namespace R5T.Z0002
{
    /// <summary>
    /// Indentations are <see cref="SyntaxTriviaList"/> instances containing only whitespace.
    /// </summary>
    [ValuesMarker]
    public partial interface IIndentations : IValuesMarker
    {
        /// <inheritdoc cref="ISyntaxTriviaListOperator.GetBlankLine"/>
        public SyntaxTriviaList BlankLine => Instances.SyntaxTriviaListOperator.GetBlankLine();

        /// <inheritdoc cref="ISyntaxTriviaListOperator.GetBlankLines_Two"/>
        public SyntaxTriviaList BlankLines_Two => Instances.SyntaxTriviaListOperator.GetBlankLines_Two();

        public SyntaxTriviaList Class => Instances.IndentationOperator.GetClassIndentation();
        public SyntaxTriviaList ClassBody => this.Method;
        public SyntaxTriviaList ClassEnding => this.Class;

        public SyntaxTriviaList Documentation_Method => this.Method;

        /// <summary>
        /// Initial is the same as <see cref="NewLine"/>.
        /// </summary>
        public SyntaxTriviaList Initial => this.NewLine;

        public SyntaxTriviaList Interface => this.Class;
        public SyntaxTriviaList InterfaceBody => this.ClassBody;

        public SyntaxTriviaList Method => Instances.IndentationOperator.GetByTabCount(
            Instances.TabCounts.MethodTabCount);
        public SyntaxTriviaList MethodBody => Instances.IndentationOperator.GetByTabCount(
            Instances.TabCounts.MethodBodyTabCount);
        public SyntaxTriviaList MethodParameter => Instances.IndentationOperator.GetByTabCount(
            Instances.TabCounts.MethodParameterTabCount);

        public SyntaxTriviaList Namespace => Instances.IndentationOperator.GetByTabCount(
            Instances.TabCounts.NamespaceTabCount);
        public SyntaxTriviaList NewLine => Instances.SyntaxTriviaListOperator.GetNewLine();
        public SyntaxTriviaList None => Instances.SyntaxTriviaListOperator.GetNew();

        public SyntaxTriviaList Property => Instances.IndentationOperator.GetByTabCount(
            Instances.TabCounts.PropertyTabCount);

        public SyntaxTriviaList Statement => this.MethodBody;

        public SyntaxTriviaList Type => this.Class;
        public SyntaxTriviaList TypeAttribute => this.Type;
    }
}
