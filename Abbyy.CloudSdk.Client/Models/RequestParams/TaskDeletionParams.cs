// Copyright � 2019 ABBYY Production LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Abbyy.CloudSdk.Client.Models.RequestParams
{
	/// <summary>
	/// Parameters for Task Deletion request
	/// </summary>
	public sealed class TaskDeletionParams
	{
		/// <summary>
		/// Required. Specifies the identifier of the task. If the task with the specified identifier does not exist, an error is returned.
		/// </summary>
		public Guid TaskId { get; set; }
	}
}
