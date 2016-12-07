﻿// <auto-generated />
namespace Microsoft.AspNetCore.SignalR
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.SignalR.Server.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        ///             /// &lt;summary&gt;Calls the {0} method on the server-side {1} hub.&amp;#10;Returns a jQuery.Deferred() promise.&lt;/summary&gt;
        /// </summary>
        internal static string DynamicComment_CallsMethodOnServerSideDeferredPromise
        {
            get { return GetString("DynamicComment_CallsMethodOnServerSideDeferredPromise"); }
        }

        /// <summary>
        ///             /// &lt;summary&gt;Calls the {0} method on the server-side {1} hub.&amp;#10;Returns a jQuery.Deferred() promise.&lt;/summary&gt;
        /// </summary>
        internal static string FormatDynamicComment_CallsMethodOnServerSideDeferredPromise(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DynamicComment_CallsMethodOnServerSideDeferredPromise"), p0, p1);
        }

        /// <summary>
        ///             /// &lt;param name=\"{0}\" type=\"{1}\"&gt;Server side type is {2}&lt;/param&gt;
        /// </summary>
        internal static string DynamicComment_ServerSideTypeIs
        {
            get { return GetString("DynamicComment_ServerSideTypeIs"); }
        }

        /// <summary>
        ///             /// &lt;param name=\"{0}\" type=\"{1}\"&gt;Server side type is {2}&lt;/param&gt;
        /// </summary>
        internal static string FormatDynamicComment_ServerSideTypeIs(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("DynamicComment_ServerSideTypeIs"), p0, p1, p2);
        }

        /// <summary>
        /// Ambiguous message. Unable to send to both '{0}' and '{1}'.
        /// </summary>
        internal static string Error_AmbiguousMessage
        {
            get { return GetString("Error_AmbiguousMessage"); }
        }

        /// <summary>
        /// Ambiguous message. Unable to send to both '{0}' and '{1}'.
        /// </summary>
        internal static string FormatError_AmbiguousMessage(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_AmbiguousMessage"), p0, p1);
        }

        /// <summary>
        /// Argument cannot be null or empty
        /// </summary>
        internal static string Error_ArgumentNullOrEmpty
        {
            get { return GetString("Error_ArgumentNullOrEmpty"); }
        }

        /// <summary>
        /// Argument cannot be null or empty
        /// </summary>
        internal static string FormatError_ArgumentNullOrEmpty()
        {
            return GetString("Error_ArgumentNullOrEmpty");
        }

        /// <summary>
        /// The buffer size '{0}' is out of range.
        /// </summary>
        internal static string Error_BufferSizeOutOfRange
        {
            get { return GetString("Error_BufferSizeOutOfRange"); }
        }

        /// <summary>
        /// The buffer size '{0}' is out of range.
        /// </summary>
        internal static string FormatError_BufferSizeOutOfRange(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_BufferSizeOutOfRange"), p0);
        }

        /// <summary>
        /// Caller is not authorized to invoke the {0} method on {1}.
        /// </summary>
        internal static string Error_CallerNotAuthorizedToInvokeMethodOn
        {
            get { return GetString("Error_CallerNotAuthorizedToInvokeMethodOn"); }
        }

        /// <summary>
        /// Caller is not authorized to invoke the {0} method on {1}.
        /// </summary>
        internal static string FormatError_CallerNotAuthorizedToInvokeMethodOn(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_CallerNotAuthorizedToInvokeMethodOn"), p0, p1);
        }

        /// <summary>
        /// The ConnectionId is in the incorrect format.
        /// </summary>
        internal static string Error_ConnectionIdIncorrectFormat
        {
            get { return GetString("Error_ConnectionIdIncorrectFormat"); }
        }

        /// <summary>
        /// The ConnectionId is in the incorrect format.
        /// </summary>
        internal static string FormatError_ConnectionIdIncorrectFormat()
        {
            return GetString("Error_ConnectionIdIncorrectFormat");
        }

        /// <summary>
        /// The PersistentConnection is not initialized.
        /// </summary>
        internal static string Error_ConnectionNotInitialized
        {
            get { return GetString("Error_ConnectionNotInitialized"); }
        }

        /// <summary>
        /// The PersistentConnection is not initialized.
        /// </summary>
        internal static string FormatError_ConnectionNotInitialized()
        {
            return GetString("Error_ConnectionNotInitialized");
        }

        /// <summary>
        /// DisconnectTimeout cannot be configured after the KeepAlive.
        /// </summary>
        internal static string Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive
        {
            get { return GetString("Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive"); }
        }

        /// <summary>
        /// DisconnectTimeout cannot be configured after the KeepAlive.
        /// </summary>
        internal static string FormatError_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive()
        {
            return GetString("Error_DisconnectTimeoutCannotBeConfiguredAfterKeepAlive");
        }

        /// <summary>
        /// DisconnectTimeout must be at least six seconds.
        /// </summary>
        internal static string Error_DisconnectTimeoutMustBeAtLeastSixSeconds
        {
            get { return GetString("Error_DisconnectTimeoutMustBeAtLeastSixSeconds"); }
        }

        /// <summary>
        /// DisconnectTimeout must be at least six seconds.
        /// </summary>
        internal static string FormatError_DisconnectTimeoutMustBeAtLeastSixSeconds()
        {
            return GetString("Error_DisconnectTimeoutMustBeAtLeastSixSeconds");
        }

        /// <summary>
        /// Do not read RequireOutgoing. Use protected _requireOutgoing instead.
        /// </summary>
        internal static string Error_DoNotReadRequireOutgoing
        {
            get { return GetString("Error_DoNotReadRequireOutgoing"); }
        }

        /// <summary>
        /// Do not read RequireOutgoing. Use protected _requireOutgoing instead.
        /// </summary>
        internal static string FormatError_DoNotReadRequireOutgoing()
        {
            return GetString("Error_DoNotReadRequireOutgoing");
        }

        /// <summary>
        /// Two Hubs must not share the same name. '{0}' and '{1}' both share the name '{2}'.
        /// </summary>
        internal static string Error_DuplicateHubNames
        {
            get { return GetString("Error_DuplicateHubNames"); }
        }

        /// <summary>
        /// Two Hubs must not share the same name. '{0}' and '{1}' both share the name '{2}'.
        /// </summary>
        internal static string FormatError_DuplicateHubNames(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_DuplicateHubNames"), p0, p1, p2);
        }

        /// <summary>
        /// Duplicate Hub names found.
        /// </summary>
        internal static string Error_DuplicateHubNamesInConnectionData
        {
            get { return GetString("Error_DuplicateHubNamesInConnectionData"); }
        }

        /// <summary>
        /// Duplicate Hub names found.
        /// </summary>
        internal static string FormatError_DuplicateHubNamesInConnectionData()
        {
            return GetString("Error_DuplicateHubNamesInConnectionData");
        }

        /// <summary>
        /// Duplicate payload id detected for stream '{0}'.
        /// </summary>
        internal static string Error_DuplicatePayloadsForStream
        {
            get { return GetString("Error_DuplicatePayloadsForStream"); }
        }

        /// <summary>
        /// Duplicate payload id detected for stream '{0}'.
        /// </summary>
        internal static string FormatError_DuplicatePayloadsForStream(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_DuplicatePayloadsForStream"), p0);
        }

        /// <summary>
        /// The ExceptionContext has already been modified once and cannot be modified again.
        /// </summary>
        internal static string Error_ExceptionContextCanOnlyBeModifiedOnce
        {
            get { return GetString("Error_ExceptionContextCanOnlyBeModifiedOnce"); }
        }

        /// <summary>
        /// The ExceptionContext has already been modified once and cannot be modified again.
        /// </summary>
        internal static string FormatError_ExceptionContextCanOnlyBeModifiedOnce()
        {
            return GetString("Error_ExceptionContextCanOnlyBeModifiedOnce");
        }

        /// <summary>
        /// '{0}' Hub could not be resolved.
        /// </summary>
        internal static string Error_HubCouldNotBeResolved
        {
            get { return GetString("Error_HubCouldNotBeResolved"); }
        }

        /// <summary>
        /// '{0}' Hub could not be resolved.
        /// </summary>
        internal static string FormatError_HubCouldNotBeResolved(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_HubCouldNotBeResolved"), p0);
        }

        /// <summary>
        /// There was an error invoking Hub method '{0}.{1}'.
        /// </summary>
        internal static string Error_HubInvocationFailed
        {
            get { return GetString("Error_HubInvocationFailed"); }
        }

        /// <summary>
        /// There was an error invoking Hub method '{0}.{1}'.
        /// </summary>
        internal static string FormatError_HubInvocationFailed(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_HubInvocationFailed"), p0, p1);
        }

        /// <summary>
        /// You cannot report progress on a hub method invocation that has already completed.
        /// </summary>
        internal static string Error_HubProgressOnlyReportableBeforeMethodReturns
        {
            get { return GetString("Error_HubProgressOnlyReportableBeforeMethodReturns"); }
        }

        /// <summary>
        /// You cannot report progress on a hub method invocation that has already completed.
        /// </summary>
        internal static string FormatError_HubProgressOnlyReportableBeforeMethodReturns()
        {
            return GetString("Error_HubProgressOnlyReportableBeforeMethodReturns");
        }

        /// <summary>
        /// Invalid cursor.
        /// </summary>
        internal static string Error_InvalidCursorFormat
        {
            get { return GetString("Error_InvalidCursorFormat"); }
        }

        /// <summary>
        /// Invalid cursor.
        /// </summary>
        internal static string FormatError_InvalidCursorFormat()
        {
            return GetString("Error_InvalidCursorFormat");
        }

        /// <summary>
        /// '{0}' is not a {1}.
        /// </summary>
        internal static string Error_IsNotA
        {
            get { return GetString("Error_IsNotA"); }
        }

        /// <summary>
        /// '{0}' is not a {1}.
        /// </summary>
        internal static string FormatError_IsNotA(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_IsNotA"), p0, p1);
        }

        /// <summary>
        /// SignalR: JavaScript Hub proxy generation has been disabled.
        /// </summary>
        internal static string Error_JavaScriptProxyDisabled
        {
            get { return GetString("Error_JavaScriptProxyDisabled"); }
        }

        /// <summary>
        /// SignalR: JavaScript Hub proxy generation has been disabled.
        /// </summary>
        internal static string FormatError_JavaScriptProxyDisabled()
        {
            return GetString("Error_JavaScriptProxyDisabled");
        }

        /// <summary>
        /// KeepAlive value must be greater than two seconds.
        /// </summary>
        internal static string Error_KeepAliveMustBeGreaterThanTwoSeconds
        {
            get { return GetString("Error_KeepAliveMustBeGreaterThanTwoSeconds"); }
        }

        /// <summary>
        /// KeepAlive value must be greater than two seconds.
        /// </summary>
        internal static string FormatError_KeepAliveMustBeGreaterThanTwoSeconds()
        {
            return GetString("Error_KeepAliveMustBeGreaterThanTwoSeconds");
        }

        /// <summary>
        /// KeepAlive value must be no more than a third of the DisconnectTimeout.
        /// </summary>
        internal static string Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout
        {
            get { return GetString("Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout"); }
        }

        /// <summary>
        /// KeepAlive value must be no more than a third of the DisconnectTimeout.
        /// </summary>
        internal static string FormatError_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout()
        {
            return GetString("Error_KeepAliveMustBeNoMoreThanAThirdOfTheDisconnectTimeout");
        }

        /// <summary>
        /// '{0}' method could not be resolved. No method found with that name.
        /// </summary>
        internal static string Error_MethodCouldNotBeResolved
        {
            get { return GetString("Error_MethodCouldNotBeResolved"); }
        }

        /// <summary>
        /// '{0}' method could not be resolved. No method found with that name.
        /// </summary>
        internal static string FormatError_MethodCouldNotBeResolved(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MethodCouldNotBeResolved"), p0);
        }

        /// <summary>
        /// '{0}' method could not be resolved. Potential candidates are: {1}
        /// </summary>
        internal static string Error_MethodCouldNotBeResolvedCandidates
        {
            get { return GetString("Error_MethodCouldNotBeResolvedCandidates"); }
        }

        /// <summary>
        /// '{0}' method could not be resolved. Potential candidates are: {1}
        /// </summary>
        internal static string FormatError_MethodCouldNotBeResolvedCandidates(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MethodCouldNotBeResolvedCandidates"), p0, p1);
        }

        /// <summary>
        /// Outgoing authorization can only be required for an entire Hub, not a specific method.
        /// </summary>
        internal static string Error_MethodLevelOutgoingAuthorization
        {
            get { return GetString("Error_MethodLevelOutgoingAuthorization"); }
        }

        /// <summary>
        /// Outgoing authorization can only be required for an entire Hub, not a specific method.
        /// </summary>
        internal static string FormatError_MethodLevelOutgoingAuthorization()
        {
            return GetString("Error_MethodLevelOutgoingAuthorization");
        }

        /// <summary>
        /// The '{0}' parameter of '{1}.{2}' must not be an out parameter.
        /// </summary>
        internal static string Error_MethodMustNotTakeOutParameter
        {
            get { return GetString("Error_MethodMustNotTakeOutParameter"); }
        }

        /// <summary>
        /// The '{0}' parameter of '{1}.{2}' must not be an out parameter.
        /// </summary>
        internal static string FormatError_MethodMustNotTakeOutParameter(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MethodMustNotTakeOutParameter"), p0, p1, p2);
        }

        /// <summary>
        /// The '{0}' parameter of '{1}.{2}' must not be a ref parameter.
        /// </summary>
        internal static string Error_MethodMustNotTakeRefParameter
        {
            get { return GetString("Error_MethodMustNotTakeRefParameter"); }
        }

        /// <summary>
        /// The '{0}' parameter of '{1}.{2}' must not be a ref parameter.
        /// </summary>
        internal static string FormatError_MethodMustNotTakeRefParameter(object p0, object p1, object p2)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MethodMustNotTakeRefParameter"), p0, p1, p2);
        }

        /// <summary>
        /// The return type of '{0}.{1}' must be void or Task.
        /// </summary>
        internal static string Error_MethodMustReturnVoidOrTask
        {
            get { return GetString("Error_MethodMustReturnVoidOrTask"); }
        }

        /// <summary>
        /// The return type of '{0}.{1}' must be void or Task.
        /// </summary>
        internal static string FormatError_MethodMustReturnVoidOrTask(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MethodMustReturnVoidOrTask"), p0, p1);
        }

        /// <summary>
        /// Multiple activators for type {0} are registered. Please call GetServices instead.
        /// </summary>
        internal static string Error_MultipleActivatorsAreaRegisteredCallGetServices
        {
            get { return GetString("Error_MultipleActivatorsAreaRegisteredCallGetServices"); }
        }

        /// <summary>
        /// Multiple activators for type {0} are registered. Please call GetServices instead.
        /// </summary>
        internal static string FormatError_MultipleActivatorsAreaRegisteredCallGetServices(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_MultipleActivatorsAreaRegisteredCallGetServices"), p0);
        }

        /// <summary>
        /// A configuration object must be specified.
        /// </summary>
        internal static string Error_NoConfiguration
        {
            get { return GetString("Error_NoConfiguration"); }
        }

        /// <summary>
        /// A configuration object must be specified.
        /// </summary>
        internal static string FormatError_NoConfiguration()
        {
            return GetString("Error_NoConfiguration");
        }

        /// <summary>
        /// A dependency resolver must be specified.
        /// </summary>
        internal static string Error_NoDependencyResolver
        {
            get { return GetString("Error_NoDependencyResolver"); }
        }

        /// <summary>
        /// A dependency resolver must be specified.
        /// </summary>
        internal static string FormatError_NoDependencyResolver()
        {
            return GetString("Error_NoDependencyResolver");
        }

        /// <summary>
        /// No transports have been enabled. There must be at least one enabled transport.
        /// </summary>
        internal static string Error_NoTransportsEnabled
        {
            get { return GetString("Error_NoTransportsEnabled"); }
        }

        /// <summary>
        /// No transports have been enabled. There must be at least one enabled transport.
        /// </summary>
        internal static string FormatError_NoTransportsEnabled()
        {
            return GetString("Error_NoTransportsEnabled");
        }

        /// <summary>
        /// Not a valid web socket request.
        /// </summary>
        internal static string Error_NotWebSocketRequest
        {
            get { return GetString("Error_NotWebSocketRequest"); }
        }

        /// <summary>
        /// Not a valid web socket request.
        /// </summary>
        internal static string FormatError_NotWebSocketRequest()
        {
            return GetString("Error_NotWebSocketRequest");
        }

        /// <summary>
        /// Unexpected end when reading object.
        /// </summary>
        internal static string Error_ParseObjectFailed
        {
            get { return GetString("Error_ParseObjectFailed"); }
        }

        /// <summary>
        /// Unexpected end when reading object.
        /// </summary>
        internal static string FormatError_ParseObjectFailed()
        {
            return GetString("Error_ParseObjectFailed");
        }

        /// <summary>
        /// Protocol error: Missing connection token.
        /// </summary>
        internal static string Error_ProtocolErrorMissingConnectionToken
        {
            get { return GetString("Error_ProtocolErrorMissingConnectionToken"); }
        }

        /// <summary>
        /// Protocol error: Missing connection token.
        /// </summary>
        internal static string FormatError_ProtocolErrorMissingConnectionToken()
        {
            return GetString("Error_ProtocolErrorMissingConnectionToken");
        }

        /// <summary>
        /// Protocol error: Unknown transport.
        /// </summary>
        internal static string Error_ProtocolErrorUnknownTransport
        {
            get { return GetString("Error_ProtocolErrorUnknownTransport"); }
        }

        /// <summary>
        /// Protocol error: Unknown transport.
        /// </summary>
        internal static string FormatError_ProtocolErrorUnknownTransport()
        {
            return GetString("Error_ProtocolErrorUnknownTransport");
        }

        /// <summary>
        /// Scaleout queuing is enabled but maximum queue size is 0
        /// </summary>
        internal static string Error_ScaleoutQueuingConfig
        {
            get { return GetString("Error_ScaleoutQueuingConfig"); }
        }

        /// <summary>
        /// Scaleout queuing is enabled but maximum queue size is 0
        /// </summary>
        internal static string FormatError_ScaleoutQueuingConfig()
        {
            return GetString("Error_ScaleoutQueuingConfig");
        }

        /// <summary>
        /// State has exceeded the maximum length of 4096 bytes.
        /// </summary>
        internal static string Error_StateExceededMaximumLength
        {
            get { return GetString("Error_StateExceededMaximumLength"); }
        }

        /// <summary>
        /// State has exceeded the maximum length of 4096 bytes.
        /// </summary>
        internal static string FormatError_StateExceededMaximumLength()
        {
            return GetString("Error_StateExceededMaximumLength");
        }

        /// <summary>
        /// The stream has been closed.
        /// </summary>
        internal static string Error_StreamClosed
        {
            get { return GetString("Error_StreamClosed"); }
        }

        /// <summary>
        /// The stream has been closed.
        /// </summary>
        internal static string FormatError_StreamClosed()
        {
            return GetString("Error_StreamClosed");
        }

        /// <summary>
        /// The stream is not open.
        /// </summary>
        internal static string Error_StreamNotOpen
        {
            get { return GetString("Error_StreamNotOpen"); }
        }

        /// <summary>
        /// The stream is not open.
        /// </summary>
        internal static string FormatError_StreamNotOpen()
        {
            return GetString("Error_StreamNotOpen");
        }

        /// <summary>
        /// The queue is full.
        /// </summary>
        internal static string Error_TaskQueueFull
        {
            get { return GetString("Error_TaskQueueFull"); }
        }

        /// <summary>
        /// The queue is full.
        /// </summary>
        internal static string FormatError_TaskQueueFull()
        {
            return GetString("Error_TaskQueueFull");
        }

        /// <summary>
        /// The type T, '{0}', passed to Hub&lt;T&gt; must be an interface.
        /// </summary>
        internal static string Error_TypeMustBeInterface
        {
            get { return GetString("Error_TypeMustBeInterface"); }
        }

        /// <summary>
        /// The type T, '{0}', passed to Hub&lt;T&gt; must be an interface.
        /// </summary>
        internal static string FormatError_TypeMustBeInterface(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_TypeMustBeInterface"), p0);
        }

        /// <summary>
        /// The interface '{0}' must not contain any events.
        /// </summary>
        internal static string Error_TypeMustNotContainEvents
        {
            get { return GetString("Error_TypeMustNotContainEvents"); }
        }

        /// <summary>
        /// The interface '{0}' must not contain any events.
        /// </summary>
        internal static string FormatError_TypeMustNotContainEvents(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_TypeMustNotContainEvents"), p0);
        }

        /// <summary>
        /// The interface '{0}' must not contain any properties.
        /// </summary>
        internal static string Error_TypeMustNotContainProperties
        {
            get { return GetString("Error_TypeMustNotContainProperties"); }
        }

        /// <summary>
        /// The interface '{0}' must not contain any properties.
        /// </summary>
        internal static string FormatError_TypeMustNotContainProperties(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Error_TypeMustNotContainProperties"), p0);
        }

        /// <summary>
        /// Unable to add module. The HubPipeline has already been invoked.
        /// </summary>
        internal static string Error_UnableToAddModulePiplineAlreadyInvoked
        {
            get { return GetString("Error_UnableToAddModulePiplineAlreadyInvoked"); }
        }

        /// <summary>
        /// Unable to add module. The HubPipeline has already been invoked.
        /// </summary>
        internal static string FormatError_UnableToAddModulePiplineAlreadyInvoked()
        {
            return GetString("Error_UnableToAddModulePiplineAlreadyInvoked");
        }

        /// <summary>
        /// Unrecognized user identity.  The user identity cannot change during an active SignalR connection.
        /// </summary>
        internal static string Error_UnrecognizedUserIdentity
        {
            get { return GetString("Error_UnrecognizedUserIdentity"); }
        }

        /// <summary>
        /// Unrecognized user identity.  The user identity cannot change during an active SignalR connection.
        /// </summary>
        internal static string FormatError_UnrecognizedUserIdentity()
        {
            return GetString("Error_UnrecognizedUserIdentity");
        }

        /// <summary>
        /// Using a Hub instance not created by the HubPipeline is unsupported.
        /// </summary>
        internal static string Error_UsingHubInstanceNotCreatedUnsupported
        {
            get { return GetString("Error_UsingHubInstanceNotCreatedUnsupported"); }
        }

        /// <summary>
        /// Using a Hub instance not created by the HubPipeline is unsupported.
        /// </summary>
        internal static string FormatError_UsingHubInstanceNotCreatedUnsupported()
        {
            return GetString("Error_UsingHubInstanceNotCreatedUnsupported");
        }

        /// <summary>
        /// WebSockets is not supported.
        /// </summary>
        internal static string Error_WebSocketsNotSupported
        {
            get { return GetString("Error_WebSocketsNotSupported"); }
        }

        /// <summary>
        /// WebSockets is not supported.
        /// </summary>
        internal static string FormatError_WebSocketsNotSupported()
        {
            return GetString("Error_WebSocketsNotSupported");
        }

        /// <summary>
        /// Forbidden: JSONP is disabled.
        /// </summary>
        internal static string Forbidden_JSONPDisabled
        {
            get { return GetString("Forbidden_JSONPDisabled"); }
        }

        /// <summary>
        /// Forbidden: JSONP is disabled.
        /// </summary>
        internal static string FormatForbidden_JSONPDisabled()
        {
            return GetString("Forbidden_JSONPDisabled");
        }

        /// <summary>
        /// SignalR services have not been registered. Register services by calling 'IServices.UseSignalR()'.
        /// </summary>
        internal static string Error_ServicesNotRegistered
        {
            get { return GetString("Error_ServicesNotRegistered"); }
        }

        /// <summary>
        /// SignalR services have not been registered. Register services by calling 'IServices.UseSignalR()'.
        /// </summary>
        internal static string FormatError_ServicesNotRegistered()
        {
            return GetString("Error_ServicesNotRegistered");
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
