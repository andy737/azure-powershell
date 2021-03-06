// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.


namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    /// <summary>
    /// Operation
    /// </summary>
    public partial class Operation
    {
        private string _description;

        /// <summary>
        /// Optional. Gets or sets the operation description
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        private string _displayName;

        /// <summary>
        /// Optional. Gets or sets the operation display name
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        private string _name;

        /// <summary>
        /// Optional. Gets or sets the operation name
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        private string _origin;

        /// <summary>
        /// Optional. Gets or sets the operation origin
        /// </summary>
        public string Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        private object _properties;

        /// <summary>
        /// Optional. Gets or sets the operation properties
        /// </summary>
        public object Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
        }
    }
}
