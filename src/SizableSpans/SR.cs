﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.SizableSpans {
    internal static class SR {

        internal static string Argument_InvalidTypeWithPointersNotSupported => "Cannot use type '{0}'. Only value types without pointers or references are supported.";

        internal static string NotSupported_CannotCallEqualsOnSizableSpan => "Calls to the Equals method are not supported.";
        internal static string NotSupported_CannotCallGetHashCodeOnSizableSpan => "Calls to the GetHashCode method are not supported.";

        internal static string Format(
#if NET7_0_OR_GREATER
                [StringSyntax(StringSyntaxAttribute.CompositeFormat)]
#endif // NET7_0_OR_GREATER
                string format, params object?[] args) {
            return string.Format(format, args);
        }
    }
}
