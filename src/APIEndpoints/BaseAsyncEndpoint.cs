﻿using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace APIEndpoints
{
    /// <summary>
    /// A base class for an endpoint that accepts parameters.
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public static class BaseAsyncEndpoint
    {
        public static class WithRequest<TRequest>
        {
            public abstract class WithResponse<TResponse> : BaseEndpointAsync
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResponse : BaseEndpointAsync
            {
                public abstract Task<ActionResult> HandleAsync(
                    TRequest request,
                    CancellationToken cancellationToken = default);
            }
        }

        public static class WithoutRequest
        {
            public abstract class WithResponse<TResponse> : BaseEndpointAsync
            {
                public abstract Task<ActionResult<TResponse>> HandleAsync(CancellationToken cancellationToken = default);
            }

            public abstract class WithoutResponse : BaseEndpointAsync
            {
                public abstract Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default);
            }
        }
    }
}