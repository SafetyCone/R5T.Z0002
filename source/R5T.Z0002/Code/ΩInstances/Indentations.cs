using System;


namespace R5T.Z0002
{
    public class Indentations : IIndentations
    {
        #region Infrastructure

        public static IIndentations Instance { get; } = new Indentations();


        private Indentations()
        {
        }

        #endregion
    }
}
