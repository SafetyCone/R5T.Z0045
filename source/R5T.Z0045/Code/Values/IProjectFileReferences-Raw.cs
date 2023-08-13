using System;

using R5T.T0131;
using R5T.T0195;
using R5T.T0195.Extensions;


namespace R5T.Z0045.Raw
{
    /// <summary>
    /// Lists useful project file references.
    /// See also: see R5T.Z0018.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectFileReferences : IValuesMarker
    {
        /// <summary>
        /// R5T.F0019 - LibGit2Sharp-related functionality.
        /// </summary>
        public IProjectFileReference R5T_F0019 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0019\source\R5T.F0019\R5T.F0019.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0020 - Code file operations functionality (CodeFileGenerator).
        /// </summary>
        public IProjectFileReference R5T_F0020 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0020\source\R5T.F0020\R5T.F0020.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0033 - Notepad++ functionality.
        /// </summary>
        public IProjectFileReference R5T_F0033 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0033\source\R5T.F0033\R5T.F0033.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0034 - Windows Explorer functionality.
        /// </summary>
        public IProjectFileReference R5T_F0034 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0034\source\R5T.F0034\R5T.F0034.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0024.T001 - Solution file model data types.
        /// </summary>
        public IProjectFileReference R5T_F0024_T001 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0024\source\R5T.F0024.T001\R5T.F0024.T001.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0053 - Code file operations functionality (CodeFileGenerator).
        /// </summary>
        public IProjectFileReference R5T_F0053 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0053\source\R5T.F0053\R5T.F0053.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0056 - Project operations functionality.
        /// </summary>
        public IProjectFileReference R5T_F0056 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0056\source\R5T.F0056\R5T.F0056.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0082 - Code file system survey functionality.
        /// </summary>
        public IProjectFileReference R5T_F0082 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0082\source\R5T.F0082\R5T.F0082.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0083 - Code file generation with Razor components.
        /// </summary>
        public IProjectFileReference R5T_F0083 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0083\source\R5T.F0083\R5T.F0083.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0115 - Project file tuples functionality.
        /// </summary>
        public IProjectFileReference R5T_F0115 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0115\source\R5T.F0115\R5T.F0115.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0129 - Solution and project paths operator (strongly-typed).
        /// </summary>
        public IProjectFileReference R5T_F0129 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0129\source\R5T.F0129\R5T.F0129.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0130 - Library file and directory path conventions.
        /// </summary>
        public IProjectFileReference R5T_F0130 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0130\source\R5T.F0130\R5T.F0130.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0131 - Library file and directory path conventions.
        /// </summary>
        public IProjectFileReference R5T_F0131 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0131\source\R5T.F0131\R5T.F0131.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0133 - Common library descriptor conversion conventions.
        /// </summary>
        public IProjectFileReference R5T_F0133 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0133\source\R5T.F0133\R5T.F0133.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0134 - Rivet-specific library descriptor conversion conventions.
        /// </summary>
        public IProjectFileReference R5T_F0134 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0134\source\R5T.F0134\R5T.F0134.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.F0138 - Dotnet framework core assembly packs related path functionality.
        /// </summary>
        public IProjectFileReference R5T_F0138 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.F0138\source\R5T.F0138\R5T.F0138.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0031 - Context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0031 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0031\source\R5T.L0031\R5T.L0031.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0032.T000 - Strong types library for various project-related XElements.
        /// </summary>
        public IProjectFileReference R5T_L0032_T000 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0032\source\R5T.L0032.T000\R5T.L0032.T000.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0033.T000 - Context types library for the project file context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0033_T000 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0033\source\R5T.L0033.T000\R5T.L0033.T000.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0034 - The .NET Standard 2.1 foundation library.
        /// </summary>
        public IProjectFileReference R5T_L0034 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0034\source\R5T.L0034\R5T.L0034.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0035 - The .NET 6.0 Foundation Library.
        /// </summary>
        public IProjectFileReference R5T_L0035 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0035\source\R5T.L0035\R5T.L0035.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0036 - Remote repository context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0036 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0036\source\R5T.L0036\R5T.L0036.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0038 - Application context library.
        /// </summary>
        public IProjectFileReference R5T_L0038 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0038\source\R5T.L0038\R5T.L0038.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0042 - Repository context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0042 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0042\source\R5T.L0042\R5T.L0042.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0040 - Project context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0040 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0040\source\R5T.L0040\R5T.L0040.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0044 - Project name operations library.
        /// </summary>
        public IProjectFileReference R5T_L0044 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0044\source\R5T.L0044\R5T.L0044.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0045 - Solution name operations library.
        /// </summary>
        public IProjectFileReference R5T_L0045 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0045\source\R5T.L0045\R5T.L0045.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0046 - Library name operations library.
        /// </summary>
        public IProjectFileReference R5T_L0046 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0046\source\R5T.L0046\R5T.L0046.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.L0047 - Local repository context operations library.
        /// </summary>
        public IProjectFileReference R5T_L0047 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.L0047\source\R5T.L0047\R5T.L0047.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.NG0019 - Roslyn (Microsoft.CodeAnalysis) NuGet package selector.
        /// </summary>
        public IProjectFileReference R5T_NG0019 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.NG0019\source\R5T.NG0019\R5T.NG0019.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.O0007 - Project description operations.
        /// </summary>
        public IProjectFileReference R5T_O0007 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.O0007\source\R5T.O0007\R5T.O0007.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.O0016 - Repository operations (combined local and remote).
        /// </summary>
        public IProjectFileReference R5T_O0016 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.O0016\source\R5T.O0016\R5T.O0016.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.O0017 - GitHub repository operations.
        /// </summary>
        public IProjectFileReference R5T_O0017 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.O0017\source\R5T.O0017\R5T.O0017.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.O0026 - Project file path operations library. (umbrella)
        /// </summary>
        public IProjectFileReference R5T_O0026 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.O0026\source\R5T.O0026\R5T.O0026.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.O0026.O002 - Visual Studio-related project path operations.
        /// </summary>
        public IProjectFileReference R5T_O0026_O002 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.O0026\source\R5T.O0026.O002\R5T.O0026.O002.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.R0009 - Common, unopinionated, basic Razor components.
        /// </summary>
        public IProjectFileReference R5T_R0009 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.R0009\source\R5T.R0009\R5T.R0009.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.R0010 - Common, opinionated, basic Razor components.
        /// </summary>
        public IProjectFileReference R5T_R0010 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.R0010\source\R5T.R0010\R5T.R0010.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.R0011 - Conventional Tailwind CSS access strategy components.
        /// </summary>
        public IProjectFileReference R5T_R0011 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.R0011\source\R5T.R0011\R5T.R0011.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0131 - Marker attribute for value instances.
        /// </summary>
        public IProjectFileReference R5T_T0131 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0131\source\R5T.T0131\R5T.T0131.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0132 - FunctionalityMarker attribute and interface.
        /// </summary>
        public IProjectFileReference R5T_T0132 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0132\source\R5T.T0132\R5T.T0132.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0137 - Context type marker attributes and interfaces.
        /// </summary>
        public IProjectFileReference R5T_T0137 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0137\source\R5T.T0137\R5T.T0137.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0142 - Marker attributes and interfaces for types: TypeMarker, DataTypeMarker, and UtilityTypeMarker.
        /// </summary>
        public IProjectFileReference R5T_T0142 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0142\source\R5T.T0142\R5T.T0142.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0159 - TextOutput type definition.
        /// </summary>
        public IProjectFileReference R5T_T0159 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0159\source\R5T.T0159\R5T.T0159.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0159.F000 - 
        /// </summary>
        public IProjectFileReference R5T_T0159_F000 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0159\source\R5T.T0159.F000\R5T.T0159.F000.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0161 - Strongly-typed code element name types. (Type name, method name, etc.)
        /// </summary>
        public IProjectFileReference R5T_T0161 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0161\source\R5T.T0161\R5T.T0161.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0172 - Strongly-typed solution file path and project file path types library.
        /// </summary>
        public IProjectFileReference R5T_T0172 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0172\source\R5T.T0172\R5T.T0172.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0179 - Strongly-typed base types.
        /// </summary>
        public IProjectFileReference R5T_T0179 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0179\source\R5T.T0179\R5T.T0179.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0180 - Common file system-related strongly-typed types (IPath, IFilePath, IDirectoryPath, etc.).
        /// </summary>
        public IProjectFileReference R5T_T0180 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0180\source\R5T.T0180\R5T.T0180.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0184 - Repository related descriptor strong-types (repository name, repository description, etc.).
        /// </summary>
        public IProjectFileReference R5T_T0184 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0184\source\R5T.T0184\R5T.T0184.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0186 - GitHub repository descriptor strong-types (repository name, owner name, etc.).
        /// </summary>
        public IProjectFileReference R5T_T0186 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0186\source\R5T.T0186\R5T.T0186.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0187 - Visual Studio project and solution descriptor name strong-types (project name, solution name, etc.).
        /// </summary>
        public IProjectFileReference R5T_T0187 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0187\source\R5T.T0187\R5T.T0187.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0193 - ITextOutputtedContext type library.
        /// </summary>
        public IProjectFileReference R5T_T0193 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0193\source\R5T.T0193\R5T.T0193.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0194 - ITextOutputtedContext type library.
        /// </summary>
        public IProjectFileReference R5T_T0194 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0194\source\R5T.T0194\R5T.T0194.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0195 - Project file reference type library.
        /// </summary>
        public IProjectFileReference R5T_T0195 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0195\source\R5T.T0195\R5T.T0195.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0197 - Library descriptor types library.
        /// </summary>
        public IProjectFileReference R5T_T0197 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0197\source\R5T.T0197\R5T.T0197.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0198 - Repository URL strong-types.
        /// </summary>
        public IProjectFileReference R5T_T0198 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0198\source\R5T.T0198\R5T.T0198.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0200 - Local repository directory path strong-types.
        /// </summary>
        public IProjectFileReference R5T_T0200 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0200\source\R5T.T0200\R5T.T0200.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0201 - HasX interface and class types for solution construction.
        /// </summary>
        public IProjectFileReference R5T_T0201 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0201\source\R5T.T0201\R5T.T0201.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0204 - .NET project specification type.
        /// </summary>
        public IProjectFileReference R5T_T0204 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0204\source\R5T.T0204\R5T.T0204.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0207 - Code element specification types library.
        /// </summary>
        public IProjectFileReference R5T_T0207 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0207\source\R5T.T0207\R5T.T0207.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0212.F000 - Project documentation file operator functionalities.
        /// </summary>
        public IProjectFileReference R5T_T0212_F000 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0212\source\R5T.T0212.F000\R5T.T0212.F000.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0215.Z000 - .NET pack name values.
        /// </summary>
        public IProjectFileReference R5T_T0215_Z000 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0215\source\R5T.T0215.Z000\R5T.T0215.Z000.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.T0222 - Organization related strong-types (like organization name).
        /// </summary>
        public IProjectFileReference R5T_T0222 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0222\source\R5T.T0222\R5T.T0222.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0015 - Useful output directory and file paths.
        /// </summary>
        public IProjectFileReference R5T_Z0015 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0015\source\R5T.Z0015\R5T.Z0015.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0022 - Code file system survey directory paths.
        /// </summary>
        public IProjectFileReference R5T_Z0022 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0022.Private\source\R5T.Z0022\R5T.Z0022.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0039 - Rivet shared data file paths.
        /// </summary>
        public IProjectFileReference R5T_Z0039 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0039.Private\source\R5T.Z0039\R5T.Z0039.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0043 - GitHub repository owner names.
        /// </summary>
        public IProjectFileReference R5T_Z0043 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0043\source\R5T.Z0043\R5T.Z0043.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0044.Z001 - Visual Studio and .NET development file extensions.
        /// </summary>
        public IProjectFileReference R5T_Z0044_Z001 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0044\source\R5T.Z0044.Z001\R5T.Z0044.Z001.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0045 - Project file references.
        /// </summary>
        public IProjectFileReference R5T_Z0045 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0045\source\R5T.Z0045\R5T.Z0045.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0046 - Strongly-typed example values for all purposes.
        /// </summary>
        public IProjectFileReference R5T_Z0046 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\R5T.Z0046.csproj".ToProjectFileReference();

        /// <summary>
        /// R5T.Z0057 - .NET target framework moniker values.
        /// </summary>
        public IProjectFileReference R5T_Z0057 => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0057\source\R5T.Z0057\R5T.Z0057.csproj".ToProjectFileReference();
    }
}
