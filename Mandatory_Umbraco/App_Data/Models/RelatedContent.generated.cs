//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.5.4
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Related Content</summary>
	[PublishedModel("relatedContent")]
	public partial class RelatedContent : PublishedContentModel, IMAster
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const string ModelTypeAlias = "relatedContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RelatedContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public RelatedContent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Main Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("mainContent")]
		public global::System.Web.IHtmlString MainContent => global::Umbraco.Web.PublishedModels.MAster.GetMainContent(this);

		///<summary>
		/// MetaDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.MAster.GetMetaDescription(this);

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("title")]
		public string Title => global::Umbraco.Web.PublishedModels.MAster.GetTitle(this);

		///<summary>
		/// TitleTag
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("titleTag")]
		public string TitleTag => global::Umbraco.Web.PublishedModels.MAster.GetTitleTag(this);

		///<summary>
		/// umbracoNaviHide
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.MAster.GetUmbracoNaviHide(this);
	}
}
