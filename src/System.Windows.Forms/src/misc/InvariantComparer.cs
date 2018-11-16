// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System {
    using System;
    using System.Collections;
    using System.Globalization;
 
    [Serializable]
    internal class InvariantComparer : IComparer {
        private CompareInfo m_compareInfo;
        internal static readonly InvariantComparer Default = new InvariantComparer();
        
        internal InvariantComparer() {
            m_compareInfo = CultureInfo.InvariantCulture.CompareInfo;
        }
  
        public int Compare(Object a, Object b) {
            String sa = a as String;
            String sb = b as String;
            if (sa != null && sb != null)
                return m_compareInfo.Compare(sa, sb);
            else
                return Comparer.Default.Compare(a,b);
        }
    }
}
