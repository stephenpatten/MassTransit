﻿// Copyright 2007-2018 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use
// this file except in compliance with the License. You may obtain a copy of the
// License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
// CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
namespace MassTransit.Initializers.Conventions
{
    public interface IMessageInitializerConvention<TMessage> :
        IMessageTypeInitializerConvention
        where TMessage : class
    {
        bool TryGetMessagePropertyInitializer<TInput, TProperty>(string propertyName, out IMessagePropertyInitializer<TMessage, TInput> initializer)
            where TInput : class;
    }


    public interface IMessageInitializerConvention<TMessage, TInput> :
        IMessageTypeInitializerConvention<TMessage>
        where TMessage : class
        where TInput : class
    {
        bool TryGetMessagePropertyInitializer<TProperty>(string propertyName, out IMessagePropertyInitializer<TMessage, TInput> convention);
    }
}