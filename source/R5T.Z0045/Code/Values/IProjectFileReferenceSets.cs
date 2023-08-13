using System;

using R5T.T0131;
using R5T.T0195;

namespace R5T.Z0045
{
    [ValuesMarker]
    public partial interface IProjectFileReferenceSets : IValuesMarker
    {
        /// <summary>
        /// Project file references for a Blazor client.
        /// </summary>
        public IProjectFileReference[] For_BlazorClient => new[]
        {
            Instances.ProjectFileReferences_Raw.R5T_R0009,
            Instances.ProjectFileReferences_Raw.R5T_R0010,
            Instances.ProjectFileReferences_Raw.R5T_R0011,
        };
    }
}
