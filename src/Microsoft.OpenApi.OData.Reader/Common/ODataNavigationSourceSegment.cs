// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using Microsoft.OData.Edm;

namespace Microsoft.OpenApi.OData.Common
{
    /// <summary>
    /// Navigation source (entity set or singleton) segment.
    /// </summary>
    public class ODataNavigationSourceSegment : ODataSegment
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ODataNavigationSourceSegment"/> class.
        /// </summary>
        /// <param name="navigaitonSource"></param>
        public ODataNavigationSourceSegment(IEdmNavigationSource navigaitonSource)
        {
            NavigationSource = navigaitonSource ?? throw Error.ArgumentNull(nameof(navigaitonSource));
        }

        public IEdmNavigationSource NavigationSource { get; }

        public override IEdmEntityType EntityType => NavigationSource.EntityType();

        public override string ToString()
        {
            return NavigationSource.Name;
        }
    }
}