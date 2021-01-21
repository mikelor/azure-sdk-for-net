// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The OrderString. </summary>
    public readonly partial struct OrderString : IEquatable<OrderString>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OrderString"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OrderString(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedAtDescValue = "CreatedAtDesc";
        private const string CreatedAtAscValue = "CreatedAtAsc";
        private const string UpdatedAtDescValue = "UpdatedAtDesc";
        private const string UpdatedAtAscValue = "UpdatedAtAsc";

        /// <summary> CreatedAtDesc. </summary>
        public static OrderString CreatedAtDesc { get; } = new OrderString(CreatedAtDescValue);
        /// <summary> CreatedAtAsc. </summary>
        public static OrderString CreatedAtAsc { get; } = new OrderString(CreatedAtAscValue);
        /// <summary> UpdatedAtDesc. </summary>
        public static OrderString UpdatedAtDesc { get; } = new OrderString(UpdatedAtDescValue);
        /// <summary> UpdatedAtAsc. </summary>
        public static OrderString UpdatedAtAsc { get; } = new OrderString(UpdatedAtAscValue);
        /// <summary> Determines if two <see cref="OrderString"/> values are the same. </summary>
        public static bool operator ==(OrderString left, OrderString right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OrderString"/> values are not the same. </summary>
        public static bool operator !=(OrderString left, OrderString right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OrderString"/>. </summary>
        public static implicit operator OrderString(string value) => new OrderString(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OrderString other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OrderString other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}