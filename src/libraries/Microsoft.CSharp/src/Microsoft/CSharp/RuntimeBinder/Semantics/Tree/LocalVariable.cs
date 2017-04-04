// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace Microsoft.CSharp.RuntimeBinder.Semantics
{
    internal class ExprLocal : Expr
    {
        public ExprLocal()
            : base(ExpressionKind.EK_LOCAL)
        {
        }

        protected ExprLocal(ExpressionKind kind)
            : base(kind)
        {
            Debug.Assert(kind == ExpressionKind.EK_THISPOINTER);
        }

        public LocalVariableSymbol Local { get; set; }

        public override CType Type => Local?.GetType();
    }
}
