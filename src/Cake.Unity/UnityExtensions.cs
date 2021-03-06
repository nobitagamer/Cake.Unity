﻿using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;
using Cake.Unity.Platforms;

namespace Cake.Unity
{
    [CakeAliasCategory("Unity")]
    public static class UnityExtensions
    {
        [CakeMethodAlias]
        [CakeAliasCategory("Build")]
        [CakeNamespaceImport("Cake.Unity.Platforms")]
        public static void UnityBuild(this ICakeContext context, DirectoryPath projectPath, UnityPlatform platform)
        {
            var tool = new UnityRunner(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            tool.Run(context, projectPath, platform);
        }
    }
}
