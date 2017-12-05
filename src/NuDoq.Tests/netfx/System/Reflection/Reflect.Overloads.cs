#region BSD License
/* 
Copyright (c) 2010, NETFx
All rights reserved.

Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.

* Neither the name of Clarius Consulting nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;

/* Overloads for static invocation patterns */

/// <devdoc>
/// Generated overloads for available Func/Action generic types 
/// for current target framework version 2.0.
/// </devdoc>
internal static partial class Reflect
{ 
	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1>(Expression<Action<T1>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2>(Expression<Action<T1, T2>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3>(Expression<Action<T1, T2, T3>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <typeparam name="T4">The type of the fourth argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, T4>(Expression<Action<T1, T2, T3, T4>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, TResult>(Expression<Func<T1, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, TResult>(Expression<Func<T1, T2, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, TResult>(Expression<Func<T1, T2, T3, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <typeparam name="T4">The type of the fourth argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, T4, TResult>(Expression<Func<T1, T2, T3, T4, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, TResult>(Expression<Func<Func<T1, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, TResult>(Expression<Func<Func<T1, T2, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, TResult>(Expression<Func<Func<T1, T2, T3, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <typeparam name="T4">The type of the fourth argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, T4, TResult>(Expression<Func<Func<T1, T2, T3, T4, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1>(Expression<Func<Action<T1>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2>(Expression<Func<Action<T1, T2>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3>(Expression<Func<Action<T1, T2, T3>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <typeparam name="T4">The type of the fourth argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, T4>(Expression<Func<Action<T1, T2, T3, T4>>> method)
	{
		return GetDelegateMethodInfo(method);
	}
}

/* Overloads for instance invocation pattern using default arguments. */

/// <devdoc>
/// Generated overloads for available Func/Action generic types 
/// for current target framework version 2.0.
/// </devdoc>
/// <typeparam name="TTarget">Type to reflect.</typeparam>
internal static partial class Reflect<TTarget>
{ 
	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1>(Expression<Action<TTarget, T1>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2>(Expression<Action<TTarget, T1, T2>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3>(Expression<Action<TTarget, T1, T2, T3>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, TResult>(Expression<Func<TTarget, T1, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, TResult>(Expression<Func<TTarget, T1, T2, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, TResult>(Expression<Func<TTarget, T1, T2, T3, TResult>> method)
	{
		return GetMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, TResult>(Expression<Func<TTarget, Func<T1, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, TResult>(Expression<Func<TTarget, Func<T1, T2, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3, TResult>(Expression<Func<TTarget, Func<T1, T2, T3, TResult>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1>(Expression<Func<TTarget, Action<T1>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2>(Expression<Func<TTarget, Action<T1, T2>>> method)
	{
		return GetDelegateMethodInfo(method);
	}

	/// <summary>
	/// Gets the method represented by the lambda expression.
	/// </summary>
	/// <param name="method">An expression that invokes a method.</param>
	/// <typeparam name="T1">The type of the first argument.</typeparam>
	/// <typeparam name="T2">The type of the second argument.</typeparam>
	/// <typeparam name="T3">The type of the third argument.</typeparam>
	/// <exception cref="ArgumentNullException">The <paramref name="method"/> is null.</exception>
	/// <exception cref="ArgumentException">The <paramref name="method"/> is not a lambda expression or it does not represent a method invocation.</exception>
	/// <returns>The method info.</returns>
	public static MethodInfo GetMethod<T1, T2, T3>(Expression<Func<TTarget, Action<T1, T2, T3>>> method)
	{
		return GetDelegateMethodInfo(method);
	}
}