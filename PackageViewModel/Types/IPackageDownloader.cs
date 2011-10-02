﻿using System;
using NuGet;

namespace NuGetPackageExplorer.Types {
    public interface IPackageDownloader {
        void Download(Uri downloadUri, string packageId, SemanticVersion packageVersion, Action<IPackage> callback);
    }
}
