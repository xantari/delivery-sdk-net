﻿using System.Collections;
using System.Collections.Generic;
using Kentico.Kontent.Delivery.Abstractions;
using Kentico.Kontent.Delivery.SharedModels;

namespace Kentico.Kontent.Delivery.ContentItems
{
    /// <inheritdoc cref="IDeliveryItemsFeedResponse{T}" />
    internal class DeliveryItemsFeedResponse<T> : AbstractItemsResponse, IEnumerable<T>, IDeliveryItemsFeedResponse<T>
    {
        /// <inheritdoc/>
        public IReadOnlyList<T> Items { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryItemsFeedResponse{T}"/> class.
        /// </summary>
        /// <param name="response">The response from Kentico Kontent Delivery API that contains a list of content items.</param>
        /// <param name="items">A list of content items.</param>
        /// <param name="linkedItems">Collection of linked content items.</param>
        internal DeliveryItemsFeedResponse(ApiResponse response, IReadOnlyList<T> items, IReadOnlyList<object> linkedItems) : base(response, linkedItems)
        {
            Items = items;
        }

        /// <inheritdoc cref="IDeliveryItemsFeedResponse{T}" />
        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection of content items.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}