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
using Newtonsoft.Json;

namespace Abbyy.CloudSdk.Client.Models.RequestParams
{
	/// <summary>
	/// Parameters for Image Processing request
	/// </summary>
	public sealed class ImageProcessingParams
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
		/// Optional. Default is <see cref="Enums.ExportFormat.Rtf"/>. Specifies the export format.
		/// </summary>
		[JsonProperty("exportFormat")]
		public ExportFormat[] ExportFormats { get; set; }

		/// <summary>
		/// Optional. Default is <see cref="Enums.ProcessingProfile.DocumentConversion"/>. Specifies a profile with predefined processing settings.
		/// </summary>
		public ProcessingProfile? Profile { get; set; }

		/// <summary>
		/// Optional. Default is <see cref="Enums.TextType.Normal"/>. Specifies the type of the text on a page.
		/// </summary>
		[JsonProperty("textType")]
		public TextType[] TextTypes { get; set; }

		/// <summary>
		/// Optional. Default is <see cref="Enums.ImageSource.Auto"/>. Specifies the source of the image.
		/// </summary>
		public ImageSource? ImageSource { get; set; }

		/// <summary>
		/// Optional. Default "true". Specifies whether the orientation of the image should be automatically detected and corrected.
		/// </summary>
		/// <list type="bullet">
		/// <item>
		/// <term>true</term>
		/// <description>The page orientation is automatically detected, and if it differs from normal the image is rotated.</description>
		/// </item>
		/// <item>
		/// <term>false</term>
		/// <description>The page orientation detection and correction is not performed.</description>
		/// </item>
		/// </list>
		public bool? CorrectOrientation { get; set; }

		/// <summary>
		/// Optional. Default "true". Specifies whether the skew of the image should be automatically detected and corrected.
		/// </summary>
		public bool? CorrectSkew { get; set; }

		/// <summary>
		/// Optional. Default "English". Specifies recognition language of the document.
		/// This parameter can contain several language names separated with commas, for example
		/// "English,French,German".
		/// </summary>
		/// <remarks>
		/// <see href="https://www.ocrsdk.com/documentation/specifications/recognition-languages/"/>
		/// </remarks>
		public string Language { get; set; }

		/// <summary>
		/// Optional. Default is <see cref="Enums.WriteTags.Auto"/>. Specifies whether the result must be written as tagged PDF.
		/// This parameter can be used only if the <see cref="ExportFormat"/> parameter contains one of the
		/// values for export to PDF.
		/// </summary>
		[JsonProperty(PropertyName = "pdf:writeTags")]
		public WriteTags? WriteTags { get; set; }

		/// <summary>
		/// Optional. Default "false". Specifies whether the variants of characters recognition
		/// should be written to an output file in XML format. This parameter can be used only
		/// if the <see cref="ExportFormat"/> parameter contains xml or xmlForCorrectedImage value. 
		/// </summary>
		[JsonProperty(PropertyName = "xml:writeRecognitionVariants")]
		public bool? WriteRecognitionVariants { get; set; }

		/// <summary>
		/// Optional. Default "false". Specifies whether the paragraph and character styles
		/// should be written to an output file in XML format. This parameter can be
		/// used only if the <see cref="ExportFormat"/> parameter contains xml or
		/// xmlForCorrectedImage value.
		/// </summary>
		[JsonProperty(PropertyName = "xml:writeFormatting")]
		public bool? WriteFormatting { get; set; }

		/// <summary>
		/// Optional. Default "true" for xml export format and "false" in other cases.
		/// Specifies whether barcodes must be detected on the image, recognized and exported
		/// to the result file.
		/// </summary>
		public bool? ReadBarcodes { get; set; }
	}
}
