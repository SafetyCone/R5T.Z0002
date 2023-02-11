using System;

using R5T.T0131;


namespace R5T.Z0002
{
	[ValuesMarker]
	public interface ITabCounts : IValuesMarker
	{
        public int ClassTabCount => this.ClassDeclarationTabCount;
        public int ClassDeclarationTabCount => 1;
        public int InterfaceOuterTabCount => 1;
        public int MethodBodyTabCount => 3;
        public int MethodTabCount => this.MethodDeclarationTabCount;
        public int MethodDeclarationTabCount => 2;
        public int MethodSignatureTabCount => 2;
        /// <summary>
        /// Three (3).
        /// </summary>
        public int MethodParameterTabCount => 3;
        /// <summary>
        /// Zero (0).
        /// </summary>
        public int NamespaceTabCount => 0;
        public int NoneTabCount => 0;
        public int Parameter => 0;
        public int PropertyTabCount => 2;
		public int TypeDeclarationTabCount => 1;
    }
}