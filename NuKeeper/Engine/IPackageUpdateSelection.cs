﻿using System.Collections.Generic;
using NuKeeper.Git;
using NuKeeper.RepositoryInspection;

namespace NuKeeper.Engine
{
    public interface IPackageUpdateSelection
    {
        List<PackageUpdateSet> SelectTargets(
            IGitDriver git,
            IEnumerable<PackageUpdateSet> potentialUpdates);
    }
}