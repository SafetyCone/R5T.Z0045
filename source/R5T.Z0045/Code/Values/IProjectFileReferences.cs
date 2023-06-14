using System;

using R5T.T0131;
using R5T.T0195;


namespace R5T.Z0045
{
    /// <summary>
    /// Lists useful project file references.
    /// See also: see R5T.Z0018.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectFileReferences : IValuesMarker
    {
        private static Raw.IProjectFileReferences Raw => Z0045.Raw.ProjectFileReferences.Instance;


        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0038"/>/>
        public IProjectFileReference For_ApplicationContext => Raw.R5T_L0038;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0142"/>/>
        public IProjectFileReference For_DataTypes => Raw.R5T_T0142;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0180"/>
        public IProjectFileReference For_FileExtensions_StrongType => Raw.R5T_T0180;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0047"/>
        public IProjectFileReference For_LocalRepositoryContext => Raw.R5T_L0047;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0035"/>
        public IProjectFileReference For_NET_6_FoundationLibrary => Raw.R5T_L0035;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0204"/>
        public IProjectFileReference For_ProjectSpecification => Raw.R5T_T0204;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0036"/>
        public IProjectFileReference For_RemoteRepositoryContext => Raw.R5T_L0036;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0042"/>
        public IProjectFileReference For_RepositoryContext => Raw.R5T_L0042;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0187"/>
        public IProjectFileReference For_SolutionName => Raw.R5T_T0187;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0207"/>
        public IProjectFileReference For_SolutionSpecifications => Raw.R5T_T0207;
    }
}
