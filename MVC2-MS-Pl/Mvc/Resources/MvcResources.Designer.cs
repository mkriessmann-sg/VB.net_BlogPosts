﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Web.Mvc.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MvcResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MvcResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Web.Mvc.Resources.MvcResources", typeof(MvcResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The current request for action &apos;{0}&apos; on controller type &apos;{1}&apos; is ambiguous between the following action methods:{2}.
        /// </summary>
        internal static string ActionMethodSelector_AmbiguousMatch {
            get {
                return ResourceManager.GetString("ActionMethodSelector_AmbiguousMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} on type {1}.
        /// </summary>
        internal static string ActionMethodSelector_AmbiguousMatchType {
            get {
                return ResourceManager.GetString("ActionMethodSelector_AmbiguousMatchType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A required anti-forgery token was not supplied or was invalid..
        /// </summary>
        internal static string AntiForgeryToken_ValidationFailed {
            get {
                return ResourceManager.GetString("AntiForgeryToken_ValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lookup for method &apos;{0}&apos; on controller type &apos;{1}&apos; failed because of an ambiguity between the following methods:{2}.
        /// </summary>
        internal static string AsyncActionMethodSelector_AmbiguousMethodMatch {
            get {
                return ResourceManager.GetString("AsyncActionMethodSelector_AmbiguousMethodMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not locate a method named &apos;{0}&apos; on controller type {1}..
        /// </summary>
        internal static string AsyncActionMethodSelector_CouldNotFindMethod {
            get {
                return ResourceManager.GetString("AsyncActionMethodSelector_CouldNotFindMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided IAsyncResult has already been consumed..
        /// </summary>
        internal static string AsyncCommon_AsyncResultAlreadyConsumed {
            get {
                return ResourceManager.GetString("AsyncCommon_AsyncResultAlreadyConsumed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller of type &apos;{0}&apos; must subclass AsyncController or implement the IAsyncManagerContainer interface..
        /// </summary>
        internal static string AsyncCommon_ControllerMustImplementIAsyncManagerContainer {
            get {
                return ResourceManager.GetString("AsyncCommon_ControllerMustImplementIAsyncManagerContainer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided IAsyncResult is not valid for this method..
        /// </summary>
        internal static string AsyncCommon_InvalidAsyncResult {
            get {
                return ResourceManager.GetString("AsyncCommon_InvalidAsyncResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The timeout value must be non-negative or Timeout.Infinite..
        /// </summary>
        internal static string AsyncCommon_InvalidTimeout {
            get {
                return ResourceManager.GetString("AsyncCommon_InvalidTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action &apos;{0}&apos; is accessible only by a child request..
        /// </summary>
        internal static string ChildActionOnlyAttribute_MustBeInChildRequest {
            get {
                return ResourceManager.GetString("ChildActionOnlyAttribute_MustBeInChildRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The field {0} must be a number..
        /// </summary>
        internal static string ClientDataTypeModelValidatorProvider_FieldMustBeNumeric {
            get {
                return ResourceManager.GetString("ClientDataTypeModelValidatorProvider_FieldMustBeNumeric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No route in the route table matches the supplied values..
        /// </summary>
        internal static string Common_NoRouteMatched {
            get {
                return ResourceManager.GetString("Common_NoRouteMatched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be null or empty..
        /// </summary>
        internal static string Common_NullOrEmpty {
            get {
                return ResourceManager.GetString("Common_NullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The partial view &apos;{0}&apos; was not found. The following locations were searched:{1}.
        /// </summary>
        internal static string Common_PartialViewNotFound {
            get {
                return ResourceManager.GetString("Common_PartialViewNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}&apos; cannot be null or empty..
        /// </summary>
        internal static string Common_PropertyCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("Common_PropertyCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0}.{1} could not be found..
        /// </summary>
        internal static string Common_PropertyNotFound {
            get {
                return ResourceManager.GetString("Common_PropertyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to False.
        /// </summary>
        internal static string Common_TriState_False {
            get {
                return ResourceManager.GetString("Common_TriState_False", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Set.
        /// </summary>
        internal static string Common_TriState_NotSet {
            get {
                return ResourceManager.GetString("Common_TriState_NotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to True.
        /// </summary>
        internal static string Common_TriState_True {
            get {
                return ResourceManager.GetString("Common_TriState_True", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} must derive from {1}.
        /// </summary>
        internal static string Common_TypeMustDriveFromType {
            get {
                return ResourceManager.GetString("Common_TypeMustDriveFromType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is invalid..
        /// </summary>
        internal static string Common_ValueNotValidForProperty {
            get {
                return ResourceManager.GetString("Common_ValueNotValidForProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The view &apos;{0}&apos; or its master was not found. The following locations were searched:{1}.
        /// </summary>
        internal static string Common_ViewNotFound {
            get {
                return ResourceManager.GetString("Common_ViewNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A public action method &apos;{0}&apos; was not found on controller &apos;{1}&apos;..
        /// </summary>
        internal static string Controller_UnknownAction {
            get {
                return ResourceManager.GetString("Controller_UnknownAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model of type &apos;{0}&apos; could not be updated..
        /// </summary>
        internal static string Controller_UpdateModel_UpdateUnsuccessful {
            get {
                return ResourceManager.GetString("Controller_UpdateModel_UpdateUnsuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model of type &apos;{0}&apos; is not valid..
        /// </summary>
        internal static string Controller_Validate_ValidationFailed {
            get {
                return ResourceManager.GetString("Controller_Validate_ValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A single instance of controller &apos;{0}&apos; cannot be used to handle multiple requests. If a custom controller factory is in use, make sure that it creates a new instance of the controller for each request..
        /// </summary>
        internal static string ControllerBase_CannotHandleMultipleRequests {
            get {
                return ResourceManager.GetString("ControllerBase_CannotHandleMultipleRequests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred when trying to create the IControllerFactory &apos;{0}&apos;. Make sure that the controller factory has a public parameterless constructor..
        /// </summary>
        internal static string ControllerBuilder_ErrorCreatingControllerFactory {
            get {
                return ResourceManager.GetString("ControllerBuilder_ErrorCreatingControllerFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IControllerFactory &apos;{0}&apos; did not return a controller for the name &apos;{1}&apos;..
        /// </summary>
        internal static string ControllerBuilder_FactoryReturnedNull {
            get {
                return ResourceManager.GetString("ControllerBuilder_FactoryReturnedNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller factory type &apos;{0}&apos; must implement the IControllerFactory interface..
        /// </summary>
        internal static string ControllerBuilder_MissingIControllerFactory {
            get {
                return ResourceManager.GetString("ControllerBuilder_MissingIControllerFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has a DisplayColumn attribute for {1}, but property {1} does not exist..
        /// </summary>
        internal static string DataAnnotationsModelMetadataProvider_UnknownProperty {
            get {
                return ResourceManager.GetString("DataAnnotationsModelMetadataProvider_UnknownProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has a DisplayColumn attribute for {1}, but property {1} does not have a public getter..
        /// </summary>
        internal static string DataAnnotationsModelMetadataProvider_UnreadableProperty {
            get {
                return ResourceManager.GetString("DataAnnotationsModelMetadataProvider_UnreadableProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type {0} must have a public constructor which accepts three parameters of types {1}, {2}, and {3}.
        /// </summary>
        internal static string DataAnnotationsModelValidatorProvider_ConstructorRequirements {
            get {
                return ResourceManager.GetString("DataAnnotationsModelValidatorProvider_ConstructorRequirements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple types were found that match the controller named &apos;{0}&apos;. This can happen if the route that services this request does not specify namespaces to search for a controller that matches the request. If this is the case, register this route by calling an overload of the &apos;MapRoute&apos; method that takes a &apos;namespaces&apos; parameter.
        ///
        ///The request for &apos;{0}&apos; has found the following matching controllers:{1}.
        /// </summary>
        internal static string DefaultControllerFactory_ControllerNameAmbiguous_WithoutRouteUrl {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_ControllerNameAmbiguous_WithoutRouteUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple types were found that match the controller named &apos;{0}&apos;. This can happen if the route that services this request (&apos;{1}&apos;) does not specify namespaces to search for a controller that matches the request. If this is the case, register this route by calling an overload of the &apos;MapRoute&apos; method that takes a &apos;namespaces&apos; parameter.
        ///
        ///The request for &apos;{0}&apos; has found the following matching controllers:{2}.
        /// </summary>
        internal static string DefaultControllerFactory_ControllerNameAmbiguous_WithRouteUrl {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_ControllerNameAmbiguous_WithRouteUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred when trying to create a controller of type &apos;{0}&apos;. Make sure that the controller has a parameterless public constructor..
        /// </summary>
        internal static string DefaultControllerFactory_ErrorCreatingController {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_ErrorCreatingController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller for path &apos;{0}&apos; was not found or does not implement IController..
        /// </summary>
        internal static string DefaultControllerFactory_NoControllerFound {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_NoControllerFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The controller type &apos;{0}&apos; must implement IController..
        /// </summary>
        internal static string DefaultControllerFactory_TypeDoesNotSubclassControllerBase {
            get {
                return ResourceManager.GetString("DefaultControllerFactory_TypeDoesNotSubclassControllerBase", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value &apos;{0}&apos; is not valid for {1}..
        /// </summary>
        internal static string DefaultModelBinder_ValueInvalid {
            get {
                return ResourceManager.GetString("DefaultModelBinder_ValueInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A value is required..
        /// </summary>
        internal static string DefaultModelBinder_ValueRequired {
            get {
                return ResourceManager.GetString("DefaultModelBinder_ValueRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of ticks for the TimeSpan value must be greater than or equal to 0..
        /// </summary>
        internal static string DefaultViewLocationCache_NegativeTimeSpan {
            get {
                return ResourceManager.GetString("DefaultViewLocationCache_NegativeTimeSpan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; does not inherit from Exception..
        /// </summary>
        internal static string ExceptionViewAttribute_NonExceptionType {
            get {
                return ResourceManager.GetString("ExceptionViewAttribute_NonExceptionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression compiler was unable to evaluate the indexer expression &apos;{0}&apos; because it references the model parameter &apos;{1}&apos; which is unavailable..
        /// </summary>
        internal static string ExpressionHelper_InvalidIndexerExpression {
            get {
                return ResourceManager.GetString("ExpressionHelper_InvalidIndexerExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Order must be greater than or equal to -1..
        /// </summary>
        internal static string FilterAttribute_OrderOutOfRange {
            get {
                return ResourceManager.GetString("FilterAttribute_OrderOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The GET and POST HTTP methods are not supported..
        /// </summary>
        internal static string HtmlHelper_InvalidHttpMethod {
            get {
                return ResourceManager.GetString("HtmlHelper_InvalidHttpMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified HttpVerbs value is not supported. The supported values are Delete, Head, and Put..
        /// </summary>
        internal static string HtmlHelper_InvalidHttpVerb {
            get {
                return ResourceManager.GetString("HtmlHelper_InvalidHttpVerb", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no ViewData item of type &apos;{1}&apos; that has the key &apos;{0}&apos;..
        /// </summary>
        internal static string HtmlHelper_MissingSelectData {
            get {
                return ResourceManager.GetString("HtmlHelper_MissingSelectData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be greater than or equal to zero..
        /// </summary>
        internal static string HtmlHelper_TextAreaParameterOutOfRange {
            get {
                return ResourceManager.GetString("HtmlHelper_TextAreaParameterOutOfRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ViewData item that has the key &apos;{0}&apos; is of type &apos;{1}&apos; but must be of type &apos;{2}&apos;..
        /// </summary>
        internal static string HtmlHelper_WrongSelectDataType {
            get {
                return ResourceManager.GetString("HtmlHelper_WrongSelectDataType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This request has been blocked because sensitive information could be disclosed to third party web sites when this is used in a GET request. To allow GET requests, set JsonRequestBehavior to AllowGet..
        /// </summary>
        internal static string JsonRequest_GetNotAllowed {
            get {
                return ResourceManager.GetString("JsonRequest_GetNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred when trying to create the IModelBinder &apos;{0}&apos;. Make sure that the binder has a public parameterless constructor..
        /// </summary>
        internal static string ModelBinderAttribute_ErrorCreatingModelBinder {
            get {
                return ResourceManager.GetString("ModelBinderAttribute_ErrorCreatingModelBinder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; does not implement the IModelBinder interface..
        /// </summary>
        internal static string ModelBinderAttribute_TypeNotIModelBinder {
            get {
                return ResourceManager.GetString("ModelBinderAttribute_TypeNotIModelBinder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; contains multiple attributes that inherit from CustomModelBinderAttribute..
        /// </summary>
        internal static string ModelBinderDictionary_MultipleAttributes {
            get {
                return ResourceManager.GetString("ModelBinderDictionary_MultipleAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This property setter is obsolete, because its value is derived from ModelMetadata.Model now..
        /// </summary>
        internal static string ModelMetadata_PropertyNotSettable {
            get {
                return ResourceManager.GetString("ModelMetadata_PropertyNotSettable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The associated metadata type for type &apos;{0}&apos; contains the following unknown properties or fields: {1}. Please make sure that the names of these members match the names of the properties on the main type..
        /// </summary>
        internal static string PrivateAssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties {
            get {
                return ResourceManager.GetString("PrivateAssociatedMetadataTypeTypeDescriptor_MetadataTypeContainsUnknownProperties" +
                        "", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Child actions are not allowed to perform redirect actions..
        /// </summary>
        internal static string RedirectAction_CannotRedirectInChildAction {
            get {
                return ResourceManager.GetString("RedirectAction_CannotRedirectInChildAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create a descriptor for instance method &apos;{0}&apos; on type &apos;{1}&apos; because the type does not derive from ControllerBase..
        /// </summary>
        internal static string ReflectedActionDescriptor_CannotCallInstanceMethodOnNonControllerType {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_CannotCallInstanceMethodOnNonControllerType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot call action method &apos;{0}&apos; on controller &apos;{1}&apos; because the parameter &apos;{2}&apos; is passed by reference..
        /// </summary>
        internal static string ReflectedActionDescriptor_CannotCallMethodsWithOutOrRefParameters {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_CannotCallMethodsWithOutOrRefParameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot call action method &apos;{0}&apos; on controller &apos;{1}&apos; because the action method is a generic method..
        /// </summary>
        internal static string ReflectedActionDescriptor_CannotCallOpenGenericMethods {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_CannotCallOpenGenericMethods", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary contains a null entry for parameter &apos;{0}&apos; of non-nullable type &apos;{1}&apos; for method &apos;{2}&apos; in &apos;{3}&apos;. An optional parameter must be a reference type, a nullable type, or be declared as an optional parameter..
        /// </summary>
        internal static string ReflectedActionDescriptor_ParameterCannotBeNull {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_ParameterCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary does not contain an entry for parameter &apos;{0}&apos; of type &apos;{1}&apos; for method &apos;{2}&apos; in &apos;{3}&apos;. The dictionary must contain an entry for each parameter, including parameters that have null values..
        /// </summary>
        internal static string ReflectedActionDescriptor_ParameterNotInDictionary {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_ParameterNotInDictionary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameters dictionary contains an invalid entry for parameter &apos;{0}&apos; for method &apos;{1}&apos; in &apos;{2}&apos;. The dictionary contains a value of type &apos;{3}&apos;, but the parameter requires a value of type &apos;{4}&apos;..
        /// </summary>
        internal static string ReflectedActionDescriptor_ParameterValueHasWrongType {
            get {
                return ResourceManager.GetString("ReflectedActionDescriptor_ParameterValueHasWrongType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The asynchronous action method &apos;{0}&apos; cannot be executed synchronously..
        /// </summary>
        internal static string ReflectedAsyncActionDescriptor_CannotExecuteSynchronously {
            get {
                return ResourceManager.GetString("ReflectedAsyncActionDescriptor_CannotExecuteSynchronously", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter &apos;{0}&apos; on method &apos;{1}&apos; contains multiple attributes that inherit from CustomModelBinderAttribute..
        /// </summary>
        internal static string ReflectedParameterBindingInfo_MultipleConverterAttributes {
            get {
                return ResourceManager.GetString("ReflectedParameterBindingInfo_MultipleConverterAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource can only be accessed via SSL..
        /// </summary>
        internal static string RequireHttpsAttribute_MustUseSsl {
            get {
                return ResourceManager.GetString("RequireHttpsAttribute_MustUseSsl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The SessionStateTempDataProvider class requires session state to be enabled..
        /// </summary>
        internal static string SessionStateTempDataProvider_SessionStateDisabled {
            get {
                return ResourceManager.GetString("SessionStateTempDataProvider_SessionStateDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An operation that crossed a synchronization context failed. See the inner exception for more information..
        /// </summary>
        internal static string SynchronizationContextUtil_ExceptionThrown {
            get {
                return ResourceManager.GetString("SynchronizationContextUtil_ExceptionThrown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate an appropriate template for type {0}..
        /// </summary>
        internal static string TemplateHelpers_NoTemplate {
            get {
                return ResourceManager.GetString("TemplateHelpers_NoTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Templates can be used only with field access, property access, single-dimension array index, or single-parameter custom indexer expressions..
        /// </summary>
        internal static string TemplateHelpers_TemplateLimitations {
            get {
                return ResourceManager.GetString("TemplateHelpers_TemplateLimitations", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Collection template was used with an object of type &apos;{0}&apos;, which does not implement System.IEnumerable..
        /// </summary>
        internal static string Templates_TypeMustImplementIEnumerable {
            get {
                return ResourceManager.GetString("Templates_TypeMustImplementIEnumerable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This file is automatically generated. Please do not modify the contents of this file..
        /// </summary>
        internal static string TypeCache_DoNotModify {
            get {
                return ResourceManager.GetString("TypeCache_DoNotModify", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter conversion from type &apos;{0}&apos; to type &apos;{1}&apos; failed. See the inner exception for more information..
        /// </summary>
        internal static string ValueProviderResult_ConversionThrew {
            get {
                return ResourceManager.GetString("ValueProviderResult_ConversionThrew", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The parameter conversion from type &apos;{0}&apos; to type &apos;{1}&apos; failed because no type converter can convert between these types..
        /// </summary>
        internal static string ValueProviderResult_NoConverterExists {
            get {
                return ResourceManager.GetString("ValueProviderResult_NoConverterExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model item passed into the dictionary is null, but this dictionary requires a non-null model item of type &apos;{0}&apos;..
        /// </summary>
        internal static string ViewDataDictionary_ModelCannotBeNull {
            get {
                return ResourceManager.GetString("ViewDataDictionary_ModelCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The model item passed into the dictionary is of type &apos;{0}&apos;, but this dictionary requires a model item of type &apos;{1}&apos;..
        /// </summary>
        internal static string ViewDataDictionary_WrongTModelType {
            get {
                return ResourceManager.GetString("ViewDataDictionary_WrongTModelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A ViewMasterPage can be used only with content pages that derive from ViewPage or ViewPage&lt;TViewItem&gt;..
        /// </summary>
        internal static string ViewMasterPage_RequiresViewPage {
            get {
                return ResourceManager.GetString("ViewMasterPage_RequiresViewPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execution of the child request failed. Please examine the InnerException for more information..
        /// </summary>
        internal static string ViewPageHttpHandlerWrapper_ExceptionOccurred {
            get {
                return ResourceManager.GetString("ViewPageHttpHandlerWrapper_ExceptionOccurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ViewUserControl &apos;{0}&apos; cannot find an IViewDataContainer object. The ViewUserControl must be inside a ViewPage, a ViewMasterPage, or another ViewUserControl..
        /// </summary>
        internal static string ViewUserControl_RequiresViewDataProvider {
            get {
                return ResourceManager.GetString("ViewUserControl_RequiresViewDataProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A ViewUserControl can be used only in pages that derive from ViewPage or ViewPage&lt;TViewItem&gt;..
        /// </summary>
        internal static string ViewUserControl_RequiresViewPage {
            get {
                return ResourceManager.GetString("ViewUserControl_RequiresViewPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A master name cannot be specified when the view is a ViewUserControl..
        /// </summary>
        internal static string WebFormViewEngine_UserControlCannotHaveMaster {
            get {
                return ResourceManager.GetString("WebFormViewEngine_UserControlCannotHaveMaster", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The view found at &apos;{0}&apos; was not created..
        /// </summary>
        internal static string WebFormViewEngine_ViewCouldNotBeCreated {
            get {
                return ResourceManager.GetString("WebFormViewEngine_ViewCouldNotBeCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The view at &apos;{0}&apos; must derive from ViewPage, ViewPage&lt;TViewData&gt;, ViewUserControl, or ViewUserControl&lt;TViewData&gt;..
        /// </summary>
        internal static string WebFormViewEngine_WrongViewBase {
            get {
                return ResourceManager.GetString("WebFormViewEngine_WrongViewBase", resourceCulture);
            }
        }
    }
}
