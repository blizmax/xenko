// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using System;
using System.Threading.Tasks;
using SiliconStudio.Core.Annotations;

namespace SiliconStudio.Presentation.Quantum.Presenters
{
    public class AnonymousNodePresenterCommand : NodePresenterCommandBase
    {
        private readonly Func<INodePresenter, object, Task> execute;
        private readonly Func<INodePresenter, bool> canAttach;

        public AnonymousNodePresenterCommand([NotNull] string name, [NotNull] Func<INodePresenter, object, Task> execute, [CanBeNull] Func<INodePresenter, bool> canAttach = null)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (execute == null) throw new ArgumentNullException(nameof(execute));
            this.execute = execute;
            this.canAttach = canAttach;
            Name = name;
        }

        /// <inheritdoc/>
        public override string Name { get; }

        /// <inheritdoc/>
        public override bool CanAttach(INodePresenter nodePresenter)
        {
            return canAttach?.Invoke(nodePresenter) ?? true;
        }

        /// <inheritdoc/>
        public override Task Execute(INodePresenter nodePresenter, object parameter, object preExecuteResult)
        {
            return execute(nodePresenter, parameter);
        }
    }
}