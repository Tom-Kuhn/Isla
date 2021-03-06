﻿using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Isla.Testing.Moq
{
	public static class ReflectionHelper
	{
		public static MethodInfo GetMethod<T> (Expression<Func<T, object>> expression)
		{
			MethodCallExpression methodCall = (MethodCallExpression)expression.Body;
			return methodCall.Method;
		}

		public static MethodInfo GetMethod<T, TResult> (Expression<Func<T, TResult>> expression)
		{
			MethodCallExpression methodCall = (MethodCallExpression)expression.Body;
			return methodCall.Method;
		}

		public static MethodInfo GetMethod<T, U, V> (Expression<Func<T, U, V>> expression)
		{
			MethodCallExpression methodCall = (MethodCallExpression)expression.Body;
			return methodCall.Method;
		}

		public static MethodInfo GetMethod (Expression<Func<object>> expression)
		{
			MethodCallExpression methodCall = (MethodCallExpression)expression.Body;
			return methodCall.Method;
		}
	}
}

