using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0198;
using R5T.T0198.Extensions;
using R5T.T0200;
using R5T.T0200.Extensions;


namespace R5T.O0023
{
    [ValuesMarker]
    public partial interface IGitOperations : IValuesMarker
    {
        public IRepositoryDirectoryPath Get_RepositoryDirectoryPath(IPath path)
        {
            var output = Instances.GitOperator.GetRepositoryDirectoryPath(path.Value)
                .ToRepositoryDirectoryPath();

            return output;
        }

        /// <remarks>
        /// Gets the remote repository URL given the directory path of a local Git repository.
        /// </remarks>
        public IRepositoryUrl Get_RepositoryUrl(IRepositoryDirectoryPath repositoryDirectoryPath)
        {
            var output = Instances.GitOperator.GetRepositoryRemoteUrl(repositoryDirectoryPath.Value)
                .ToRepositoryUrl();

            return output;
        }

        public bool 
    }
}
