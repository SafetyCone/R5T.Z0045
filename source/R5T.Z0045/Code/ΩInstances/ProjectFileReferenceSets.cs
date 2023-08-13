using System;


namespace R5T.Z0045
{
    public class ProjectFileReferenceSets : IProjectFileReferenceSets
    {
        #region Infrastructure

        public static IProjectFileReferenceSets Instance { get; } = new ProjectFileReferenceSets();


        private ProjectFileReferenceSets()
        {
        }

        #endregion
    }
}
