﻿using System;
using System.Linq;
using System.Reflection;

namespace Namotion.Reflection
{
    public abstract class MemberWithContext : TypeWithContext
    {
        internal MemberWithContext(MemberInfo memberInfo, Type memberType, ref int nullableFlagsIndex) 
            : base(memberType, memberInfo.GetCustomAttributes(true).OfType<Attribute>().ToArray(), null, null, ref nullableFlagsIndex)
        {
        }

        /// <summary>
        /// Gets the type context's member info.
        /// </summary>
        public abstract MemberInfo MemberInfo { get; }

        /// <summary>
        /// Returns the value of a field supported by a given object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns>The value.</returns>
        public abstract object GetValue(object obj);

        /// <summary>
        /// Sets the value of the field supported by the given object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <param name="value">The value.</param>
        public abstract void SetValue(object obj, object value);
    }
}
