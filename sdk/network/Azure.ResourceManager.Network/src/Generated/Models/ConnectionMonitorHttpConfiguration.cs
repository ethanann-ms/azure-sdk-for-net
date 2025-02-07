// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the HTTP configuration. </summary>
    public partial class ConnectionMonitorHttpConfiguration
    {
        /// <summary> Initializes a new instance of ConnectionMonitorHttpConfiguration. </summary>
        public ConnectionMonitorHttpConfiguration()
        {
            RequestHeaders = new ChangeTrackingList<NetworkWatcherHttpHeader>();
            ValidStatusCodeRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ConnectionMonitorHttpConfiguration. </summary>
        /// <param name="port"> The port to connect to. </param>
        /// <param name="method"> The HTTP method to use. </param>
        /// <param name="path"> The path component of the URI. For instance, "/dir1/dir2". </param>
        /// <param name="requestHeaders"> The HTTP headers to transmit with the request. </param>
        /// <param name="validStatusCodeRanges"> HTTP status codes to consider successful. For instance, "2xx,301-304,418". </param>
        /// <param name="preferHttps"> Value indicating whether HTTPS is preferred over HTTP in cases where the choice is not explicit. </param>
        internal ConnectionMonitorHttpConfiguration(int? port, NetworkHttpConfigurationMethod? method, string path, IList<NetworkWatcherHttpHeader> requestHeaders, IList<string> validStatusCodeRanges, bool? preferHttps)
        {
            Port = port;
            Method = method;
            Path = path;
            RequestHeaders = requestHeaders;
            ValidStatusCodeRanges = validStatusCodeRanges;
            PreferHttps = preferHttps;
        }

        /// <summary> The port to connect to. </summary>
        public int? Port { get; set; }
        /// <summary> The HTTP method to use. </summary>
        public NetworkHttpConfigurationMethod? Method { get; set; }
        /// <summary> The path component of the URI. For instance, "/dir1/dir2". </summary>
        public string Path { get; set; }
        /// <summary> The HTTP headers to transmit with the request. </summary>
        public IList<NetworkWatcherHttpHeader> RequestHeaders { get; }
        /// <summary> HTTP status codes to consider successful. For instance, "2xx,301-304,418". </summary>
        public IList<string> ValidStatusCodeRanges { get; }
        /// <summary> Value indicating whether HTTPS is preferred over HTTP in cases where the choice is not explicit. </summary>
        public bool? PreferHttps { get; set; }
    }
}
