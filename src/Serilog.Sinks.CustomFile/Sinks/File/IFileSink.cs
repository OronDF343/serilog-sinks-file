﻿// Copyright 2017 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Serilog.Core;
using Serilog.Events;

namespace Serilog.Sinks.CustomFile
{
    /// <summary>
    /// Exists only for the convenience of <see cref="RollingFileSink"/>, which
    /// switches implementations based on sharing. Would refactor, but preserving
    /// backwards compatibility.
    /// </summary>
    interface IFileSink : ILogEventSink, IFlushableFileSink
    {
        bool EmitOrOverflow(LogEvent logEvent);
    }
}
