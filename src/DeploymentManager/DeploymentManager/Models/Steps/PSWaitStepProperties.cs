﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.DeploymentManager.Models
{
    using Microsoft.Azure.Management.DeploymentManager.Models;

    public class PSWaitStepProperties : PSStepProperties
    {
        public PSWaitStepProperties() : base()
        {
        }

        public PSWaitStepProperties(WaitStepProperties waitStepProperties) : base(waitStepProperties)
        {
            this.Duration = waitStepProperties.Attributes?.Duration;
        }

        public string Duration { get; set; }

        internal override StepProperties ToSdkType()
        {
            return new WaitStepProperties(new WaitStepAttributes(this.Duration));
        }
    }
}