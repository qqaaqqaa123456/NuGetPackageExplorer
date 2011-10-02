using System;
using System.Collections.Generic;

namespace NuGet {
    public interface IPackageMetadata {
        string Id { get; }
        SemanticVersion Version { get; }
        string Title { get; }
        IEnumerable<string> Authors { get; }
        IEnumerable<string> Owners { get; }
        Uri IconUrl { get; }
        Uri LicenseUrl { get; }
        Uri ProjectUrl { get; }
        bool RequireLicenseAcceptance { get; }
        string Description { get; }
        string Summary { get; }
        string ReleaseNotes { get; }
        string Copyright { get; }
        string Language { get; }
        string Tags { get; }
        IEnumerable<FrameworkAssemblyReference> FrameworkAssemblies { get; }
        IEnumerable<PackageDependency> Dependencies { get; }
        IEnumerable<AssemblyReference> References { get; }
    }
}