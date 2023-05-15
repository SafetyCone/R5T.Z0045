using System;


namespace R5T.Z0045.Raw
{
    public class ProjectFileReferences : IProjectFileReferences
    {
        #region Infrastructure

        public static IProjectFileReferences Instance { get; } = new ProjectFileReferences();


        private ProjectFileReferences()
        {
        }

        #endregion
    }
}
