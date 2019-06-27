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

using Abbyy.CloudSdk.Client.Models.Enums;

namespace Abbyy.CloudSdk.Client.Models.RequestParams
{
	/// <summary>
	/// Parameters for Checkmark Field Processing request
	/// </summary>
	public class CheckmarkFieldProcessingParams
	{
		/// <summary>
		/// Optional. Contains a password for accessing password-protected images in PDF format.
		/// </summary>
		public string PdfPassword { get; set; }

		/// <summary>
		/// Optional. Contains the description of the processing task. Cannot contain more than 255 characters.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Optional. Default "-1,-1,-1,-1". Specifies the region of the text field on the image. The coordinates of the region are measured in pixels relative to the left top corner of the image and are specified in the following order: left, top, right, bottom. By default, the region of the whole image is used.
		/// </summary>
		public string Region { get; set; }

		/// <summary>
		/// Optional. Default is <see cref="Enums.CheckmarkType.Empty"/>. Specifies the type of the checkmark.
		/// </summary>
		public CheckmarkType? CheckmarkType { get; set; }

		/// <summary>
		/// Optional. Default "false". This property set to true means that checkmark block can be selected and then corrected.
		/// </summary>
		public bool? CorrectionAllowed { get; set; }
	}
}
