// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.IIS.Administration.WebServer.RequestFiltering {
    using Web.Administration;

    public class ScanHeaderElement : ConfigurationElement {
        
        public ScanHeaderElement() {
        }
        
        public string RequestHeader {
            get {
                return ((string)(base["requestHeader"]));
            }
            set {
                base["requestHeader"] = value;
            }
        }
    }
}
