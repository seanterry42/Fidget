﻿/*  Copyright 2017 Sean Terry

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License. 
*/

using System.Threading;
using System.Threading.Tasks;

namespace Fidget.Commander
{
    /// <summary>
    /// Defines a handler for executing a command that returns no result.
    /// </summary>
    /// <typeparam name="TCommand">Type of the command.</typeparam>

    public interface ICommandHandler<in TCommand> where TCommand : ICommand 
    {
        /// <summary>
        /// Handles execution of the command.
        /// </summary>
        /// <param name="command">Command to be executed.</param>
        /// <param name="cancellationToken">Cancellation token.</param>
        
        Task Handle( TCommand command, CancellationToken cancellationToken );
    }
}