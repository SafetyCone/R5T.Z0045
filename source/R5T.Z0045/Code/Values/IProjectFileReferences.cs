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


        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_T0180"/>
        public IProjectFileReference For_FileExtensions_StrongType => Raw.R5T_T0180;

        /// <inheritdoc cref="Raw.IProjectFileReferences.R5T_L0035"/>
        public IProjectFileReference For_NET_6_FoundationLibrary => Raw.R5T_L0035;
    }
}
