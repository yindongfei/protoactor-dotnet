// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Messages {
  public static class HelloGrain
  {
    static readonly string __ServiceName = "messages.HelloGrain";

    static readonly Marshaller<global::Messages.HelloRequest> __Marshaller_HelloRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Messages.HelloRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Messages.HelloResponse> __Marshaller_HelloResponse = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Messages.HelloResponse.Parser.ParseFrom);

    static readonly Method<global::Messages.HelloRequest, global::Messages.HelloResponse> __Method_SayHello = new Method<global::Messages.HelloRequest, global::Messages.HelloResponse>(
        MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Messages.ProtosReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of HelloGrain</summary>
    public abstract class HelloGrainBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Messages.HelloResponse> SayHello(global::Messages.HelloRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for HelloGrain</summary>
    public class HelloGrainClient : ClientBase<HelloGrainClient>
    {
      /// <summary>Creates a new client for HelloGrain</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HelloGrainClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HelloGrain that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HelloGrainClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HelloGrainClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HelloGrainClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Messages.HelloResponse SayHello(global::Messages.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SayHello(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Messages.HelloResponse SayHello(global::Messages.HelloRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Messages.HelloResponse> SayHelloAsync(global::Messages.HelloRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return SayHelloAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Messages.HelloResponse> SayHelloAsync(global::Messages.HelloRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      protected override HelloGrainClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HelloGrainClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(HelloGrainBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello).Build();
    }

  }
}
#endregion
