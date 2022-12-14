// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Demo2Grpc.Protos {
  public static partial class GrpcCustomer
  {
    static readonly string __ServiceName = "GrpcCustomer";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Demo2Grpc.Protos.Empty> __Marshaller_Empty = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo2Grpc.Protos.Empty.Parser));
    static readonly grpc::Marshaller<global::Demo2Grpc.Protos.CustomerList> __Marshaller_CustomerList = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo2Grpc.Protos.CustomerList.Parser));
    static readonly grpc::Marshaller<global::Demo2Grpc.Protos.IDRequest> __Marshaller_IDRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo2Grpc.Protos.IDRequest.Parser));
    static readonly grpc::Marshaller<global::Demo2Grpc.Protos.Customer> __Marshaller_Customer = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Demo2Grpc.Protos.Customer.Parser));

    static readonly grpc::Method<global::Demo2Grpc.Protos.Empty, global::Demo2Grpc.Protos.CustomerList> __Method_GetAll = new grpc::Method<global::Demo2Grpc.Protos.Empty, global::Demo2Grpc.Protos.CustomerList>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_Empty,
        __Marshaller_CustomerList);

    static readonly grpc::Method<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Customer> __Method_GetCustomer = new grpc::Method<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Customer>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomer",
        __Marshaller_IDRequest,
        __Marshaller_Customer);

    static readonly grpc::Method<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty> __Method_AddCustomer = new grpc::Method<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddCustomer",
        __Marshaller_Customer,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty> __Method_UpdateCustomer = new grpc::Method<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateCustomer",
        __Marshaller_Customer,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Empty> __Method_DeleteCustomer = new grpc::Method<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteCustomer",
        __Marshaller_IDRequest,
        __Marshaller_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Demo2Grpc.Protos.CustomerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GrpcCustomer</summary>
    [grpc::BindServiceMethod(typeof(GrpcCustomer), "BindService")]
    public abstract partial class GrpcCustomerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Demo2Grpc.Protos.CustomerList> GetAll(global::Demo2Grpc.Protos.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo2Grpc.Protos.Customer> GetCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo2Grpc.Protos.Empty> AddCustomer(global::Demo2Grpc.Protos.Customer request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo2Grpc.Protos.Empty> UpdateCustomer(global::Demo2Grpc.Protos.Customer request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Demo2Grpc.Protos.Empty> DeleteCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GrpcCustomer</summary>
    public partial class GrpcCustomerClient : grpc::ClientBase<GrpcCustomerClient>
    {
      /// <summary>Creates a new client for GrpcCustomer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GrpcCustomerClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GrpcCustomer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GrpcCustomerClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GrpcCustomerClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GrpcCustomerClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Demo2Grpc.Protos.CustomerList GetAll(global::Demo2Grpc.Protos.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo2Grpc.Protos.CustomerList GetAll(global::Demo2Grpc.Protos.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.CustomerList> GetAllAsync(global::Demo2Grpc.Protos.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.CustomerList> GetAllAsync(global::Demo2Grpc.Protos.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      public virtual global::Demo2Grpc.Protos.Customer GetCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo2Grpc.Protos.Customer GetCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Customer> GetCustomerAsync(global::Demo2Grpc.Protos.IDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Customer> GetCustomerAsync(global::Demo2Grpc.Protos.IDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomer, null, options, request);
      }
      public virtual global::Demo2Grpc.Protos.Empty AddCustomer(global::Demo2Grpc.Protos.Customer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo2Grpc.Protos.Empty AddCustomer(global::Demo2Grpc.Protos.Customer request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddCustomer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> AddCustomerAsync(global::Demo2Grpc.Protos.Customer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> AddCustomerAsync(global::Demo2Grpc.Protos.Customer request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddCustomer, null, options, request);
      }
      public virtual global::Demo2Grpc.Protos.Empty UpdateCustomer(global::Demo2Grpc.Protos.Customer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo2Grpc.Protos.Empty UpdateCustomer(global::Demo2Grpc.Protos.Customer request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateCustomer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> UpdateCustomerAsync(global::Demo2Grpc.Protos.Customer request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> UpdateCustomerAsync(global::Demo2Grpc.Protos.Customer request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateCustomer, null, options, request);
      }
      public virtual global::Demo2Grpc.Protos.Empty DeleteCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Demo2Grpc.Protos.Empty DeleteCustomer(global::Demo2Grpc.Protos.IDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> DeleteCustomerAsync(global::Demo2Grpc.Protos.IDRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Demo2Grpc.Protos.Empty> DeleteCustomerAsync(global::Demo2Grpc.Protos.IDRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteCustomer, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GrpcCustomerClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GrpcCustomerClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GrpcCustomerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_GetCustomer, serviceImpl.GetCustomer)
          .AddMethod(__Method_AddCustomer, serviceImpl.AddCustomer)
          .AddMethod(__Method_UpdateCustomer, serviceImpl.UpdateCustomer)
          .AddMethod(__Method_DeleteCustomer, serviceImpl.DeleteCustomer).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GrpcCustomerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo2Grpc.Protos.Empty, global::Demo2Grpc.Protos.CustomerList>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_GetCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Customer>(serviceImpl.GetCustomer));
      serviceBinder.AddMethod(__Method_AddCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty>(serviceImpl.AddCustomer));
      serviceBinder.AddMethod(__Method_UpdateCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo2Grpc.Protos.Customer, global::Demo2Grpc.Protos.Empty>(serviceImpl.UpdateCustomer));
      serviceBinder.AddMethod(__Method_DeleteCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Demo2Grpc.Protos.IDRequest, global::Demo2Grpc.Protos.Empty>(serviceImpl.DeleteCustomer));
    }

  }
}
#endregion
