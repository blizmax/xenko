// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;

namespace SiliconStudio.Quantum
{
    public interface IMemberNodeInternal : IInitializingGraphNode, IMemberNode
    {
        event EventHandler<INodeChangeEventArgs> PrepareChange;
        event EventHandler<INodeChangeEventArgs> FinalizeChange;
    }
}
