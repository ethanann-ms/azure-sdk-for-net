// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino cluster catalog options. </summary>
    internal partial class CatalogOptions
    {
        /// <summary> Initializes a new instance of CatalogOptions. </summary>
        public CatalogOptions()
        {
            Hive = new ChangeTrackingList<HiveCatalogOption>();
        }

        /// <summary> Initializes a new instance of CatalogOptions. </summary>
        /// <param name="hive"> hive catalog options. </param>
        internal CatalogOptions(IList<HiveCatalogOption> hive)
        {
            Hive = hive;
        }

        /// <summary> hive catalog options. </summary>
        public IList<HiveCatalogOption> Hive { get; }
    }
}
