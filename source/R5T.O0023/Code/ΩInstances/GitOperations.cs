using System;


namespace R5T.O0023
{
    public class GitOperations : IGitOperations
    {
        #region Infrastructure

        public static IGitOperations Instance { get; } = new GitOperations();


        private GitOperations()
        {
        }

        #endregion
    }
}
