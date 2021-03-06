﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Verifies conditions in unit tests using true/false propositions.
    /// </summary>
    public static class Assert
    {
        internal static EventHandler<EventArgs> AssertionFailure;

        /// <summary>
        /// Verifies that the specified condition is true. The assertion fails if the condition is false.
        /// </summary>
        /// <param name="condition">The condition to verify is true.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to false.</exception>
        public static void IsTrue(bool condition)
        {
            Assert.IsTrue(condition, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified condition is true. The assertion fails if the condition is false. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="condition">The condition to verify is true.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to false.</exception>
        public static void IsTrue(bool condition, string message)
        {
            Assert.IsTrue(condition, message, null);
        }

        /// <summary>
        /// Verifies that the specified condition is true. The assertion fails if the condition is false. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="condition">The condition to verify is true.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to false.</exception>
        public static void IsTrue(bool condition, string message, params object[] parameters)
        {
            if (condition)
                return;
            Assert.HandleFail("Assert.IsTrue", message, parameters);
        }

        /// <summary>
        /// Verifies that the specified condition is false. The assertion fails if the condition is true.
        /// </summary>
        /// <param name="condition">The condition to verify is false.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to true.</exception>
        public static void IsFalse(bool condition)
        {
            Assert.IsFalse(condition, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified condition is false. The assertion fails if the condition is true. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="condition">The condition to verify is false.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to true.</exception>
        public static void IsFalse(bool condition, string message)
        {
            Assert.IsFalse(condition, message, null);
        }

        /// <summary>
        /// Verifies that the specified condition is false. The assertion fails if the condition is true. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="condition">The condition to verify is false.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="condition"/> evaluates to true.</exception>
        public static void IsFalse(bool condition, string message, params object[] parameters)
        {
            if (!condition)
                return;
            Assert.HandleFail("Assert.IsFalse", message, parameters);
        }

        /// <summary>
        /// Verifies that the specified object is null. The assertion fails if it is not null.
        /// </summary>
        /// <param name="value">The object to verify is null.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null.</exception>
        public static void IsNull(object value)
        {
            Assert.IsNull(value, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified object is null. The assertion fails if it is not null. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="value">The object to verify is null.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null.</exception>
        public static void IsNull(object value, string message)
        {
            Assert.IsNull(value, message, null);
        }

        /// <summary>
        /// Verifies that the specified object is null. The assertion fails if it is not null. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="value">The object to verify is null.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null.</exception>
        public static void IsNull(object value, string message, params object[] parameters)
        {
            if (value == null)
                return;
            Assert.HandleFail("Assert.IsNull", message, parameters);
        }

        /// <summary>
        /// Verifies that the specified object is not null. The assertion fails if it is null.
        /// </summary>
        /// <param name="value">The object to verify is not null.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null.</exception>
        public static void IsNotNull(object value)
        {
            Assert.IsNotNull(value, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified object is not null. The assertion fails if it is null. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="value">The object to verify is not null.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null.</exception>
        public static void IsNotNull(object value, string message)
        {
            Assert.IsNotNull(value, message, null);
        }

        /// <summary>
        /// Verifies that the specified object is not null. The assertion fails if it is null. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="value">The object to verify is not null.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null.</exception>
        public static void IsNotNull(object value, string message, params object[] parameters)
        {
            if (value != null)
                return;
            Assert.HandleFail("Assert.IsNotNull", message, parameters);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to the same object. The assertion fails if they refer to different objects.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> does not refer to the same object as <paramref name="actual"/>.</exception>
        public static void AreSame(object expected, object actual)
        {
            Assert.AreSame(expected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to the same object. The assertion fails if they refer to different objects. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> does not refer to the same object as <paramref name="actual"/>.</exception>
        public static void AreSame(object expected, object actual, string message)
        {
            Assert.AreSame(expected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to the same object. The assertion fails if they refer to different objects. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> does not refer to the same object as <paramref name="actual"/>.</exception>
        public static void AreSame(object expected, object actual, string message, params object[] parameters)
        {
            if (object.ReferenceEquals(expected, actual))
                return;
            string message1 = message;
            if (expected is ValueType && actual is ValueType)
                message1 = string.Format("Do not pass value types to AreSame(). Values converted to Object will never be the same. Consider using AreEqual(). {0}", message == null ? string.Empty : Assert.ReplaceNulls(message));
            Assert.HandleFail("Assert.AreSame", message1, parameters);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to different objects. The assertion fails if they refer to the same object.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> refers to the same object as <paramref name="actual"/>.</exception>
        public static void AreNotSame(object notExpected, object actual)
        {
            Assert.AreNotSame(notExpected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to different objects. The assertion fails if they refer to the same object. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> refers to the same object as <paramref name="actual"/>.</exception>
        public static void AreNotSame(object notExpected, object actual, string message)
        {
            Assert.AreNotSame(notExpected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified object variables refer to different objects. The assertion fails if they refer to the same object. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> refers to the same object as <paramref name="actual"/>.</exception>
        public static void AreNotSame(object notExpected, object actual, string message, params object[] parameters)
        {
            if (!object.ReferenceEquals(notExpected, actual))
                return;
            Assert.HandleFail("Assert.AreNotSame", message, parameters);
        }

        /// <summary>
        /// Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal.
        /// </summary>
        /// <param name="expected">The first generic type data to compare. This is the generic type data the unit test expects.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual<T>(T expected, T actual)
        {
            Assert.AreEqual<T>(expected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first generic type data to compare. This is the generic type data the unit test expects.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual<T>(T expected, T actual, string message)
        {
            Assert.AreEqual<T>(expected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified generic type data are equal by using the equality operator. The assertion fails if they are not equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first generic type data to compare. This is the generic type data the unit test expects.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual<T>(T expected, T actual, string message, params object[] parameters)
        {
            message = Assert.CreateCompleteMessage(message, parameters);
            if (object.Equals(expected, actual))
                return;
            Assert.HandleFailure("Assert.AreEqual", actual == null || expected == null || actual.GetType().Equals(expected.GetType()) ? string.Format("Expected:&lt;{1}&gt;. Actual:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(expected), Assert.ReplaceNulls(actual)) : string.Format("Expected:&lt;{1} ({2})&gt;. Actual:&lt;{3} ({4})&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(expected), expected.GetType().FullName, Assert.ReplaceNulls(actual), actual.GetType().FullName));
        }

        /// <summary>
        /// Verifies that two specified generic type data are not equal. The assertion fails if they are equal.
        /// </summary>
        /// <param name="notExpected">The first generic type data to compare. This is the generic type data the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual<T>(T notExpected, T actual)
        {
            Assert.AreNotEqual<T>(notExpected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified generic type data are not equal. The assertion fails if they are equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first generic type data to compare. This is the generic type data the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual<T>(T notExpected, T actual, string message)
        {
            Assert.AreNotEqual<T>(notExpected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified generic type data are not equal. The assertion fails if they are equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first generic type data to compare. This is the generic type data the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second generic type data to compare. This is the generic type data the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><typeparam name="T"/><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual<T>(T notExpected, T actual, string message, params object[] parameters)
        {
            message = Assert.CreateCompleteMessage(message, parameters);
            if (!object.Equals(notExpected, actual))
                return;
            Assert.HandleFailure("Assert.AreNotEqual", string.Format("Expected any value except:&lt;{1}&gt;. Actual:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(notExpected), Assert.ReplaceNulls(actual)));
        }

        /// <summary>
        /// Verifies that two specified objects are equal. The assertion fails if the objects are not equal.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(object expected, object actual)
        {
            Assert.AreEqual(expected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified objects are equal. The assertion fails if the objects are not equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(object expected, object actual, string message)
        {
            Assert.AreEqual(expected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified objects are equal. The assertion fails if the objects are not equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first object to compare. This is the object the unit test expects.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(object expected, object actual, string message, params object[] parameters)
        {
            Assert.AreEqual<object>(expected, actual, message, parameters);
        }

        /// <summary>
        /// Verifies that two specified objects are not equal. The assertion fails if the objects are equal.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(object notExpected, object actual)
        {
            Assert.AreNotEqual(notExpected, actual, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified objects are not equal. The assertion fails if the objects are equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(object notExpected, object actual, string message)
        {
            Assert.AreNotEqual(notExpected, actual, message, null);
        }

        /// <summary>
        /// Verifies that two specified objects are not equal. The assertion fails if the objects are equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first object to compare. This is the object the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second object to compare. This is the object the unit test produced.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(object notExpected, object actual, string message, params object[] parameters)
        {
            Assert.AreNotEqual<object>(notExpected, actual, message, parameters);
        }

        /// <summary>
        /// Verifies that two specified singles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other.
        /// </summary>
        /// <param name="expected">The first single to compare. This is the single the unit test expects.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(float expected, float actual, float delta)
        {
            Assert.AreEqual(expected, actual, delta, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified singles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first single to compare. This is the single the unit test expects.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(float expected, float actual, float delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message, null);
        }

        /// <summary>
        /// Verifies that two specified singles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first single to compare. This is the single the unit test expects.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</exception>
        public static void AreEqual(float expected, float actual, float delta, string message, params object[] parameters)
        {
            if (float.IsNaN(expected) || float.IsNaN(actual) || float.IsNaN(delta))
                Assert.HandleFail("Assert.AreEqual", string.Format("Expected a difference no greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), expected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
            if (Math.Abs(expected - actual) <= (double)delta)
                return;
            Assert.HandleFail("Assert.AreEqual", string.Format("Expected a difference no greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), expected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
        }

        /// <summary>
        /// Verifies that two specified singles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other.
        /// </summary>
        /// <param name="notExpected">The first single to compare. This is the single the unit test expects.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required inaccuracy. The assertion will fail only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(float notExpected, float actual, float delta)
        {
            Assert.AreNotEqual(notExpected, actual, delta, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified singles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first single to compare. This is the single the unit test expects.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required inaccuracy. The assertion will fail only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(float notExpected, float actual, float delta, string message)
        {
            Assert.AreNotEqual(notExpected, actual, delta, message, null);
        }

        /// <summary>
        /// Verifies that two specified singles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first single to compare. This is the single the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second single to compare. This is the single the unit test produced.</param><param name="delta">The required inaccuracy. The assertion will fail only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(float notExpected, float actual, float delta, string message, params object[] parameters)
        {
            if (Math.Abs(notExpected - actual) > (double)delta)
                return;
            Assert.HandleFail("Assert.AreNotEqual", string.Format("Expected a difference greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), notExpected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
        }

        /// <summary>
        /// Verifies that two specified doubles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other.
        /// </summary>
        /// <param name="expected">The first double to compare. This is the double the unit test expects.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</exception>
        public static void AreEqual(double expected, double actual, double delta)
        {
            Assert.AreEqual(expected, actual, delta, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified doubles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first double to compare. This is the double the unit test expects.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</exception>
        public static void AreEqual(double expected, double actual, double delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message, null);
        }

        /// <summary>
        /// Verifies that two specified doubles are equal, or within the specified accuracy of each other. The assertion fails if they are not within the specified accuracy of each other. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first double to compare. This is the double the unit tests expects.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required accuracy. The assertion will fail only if <paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is different from <paramref name="actual"/> by more than <paramref name="delta"/>.</exception>
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] parameters)
        {
            if (double.IsNaN(expected) || double.IsNaN(actual) || double.IsNaN(delta))
                Assert.HandleFail("Assert.AreEqual", string.Format("Expected a difference no greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), expected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
            if (Math.Abs(expected - actual) <= delta)
                return;
            Assert.HandleFail("Assert.AreEqual", string.Format("Expected a difference no greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), expected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
        }

        /// <summary>
        /// Verifies that two specified doubles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other.
        /// </summary>
        /// <param name="notExpected">The first double to compare. This is the double the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required inaccuracy. The assertion fails only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(double notExpected, double actual, double delta)
        {
            Assert.AreNotEqual(notExpected, actual, delta, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified doubles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first double to compare. This is the double the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required inaccuracy. The assertion fails only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(double notExpected, double actual, double delta, string message)
        {
            Assert.AreNotEqual(notExpected, actual, delta, message, null);
        }

        /// <summary>
        /// Verifies that two specified doubles are not equal, and not within the specified accuracy of each other. The assertion fails if they are equal or within the specified accuracy of each other. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first double to compare. This is the double the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second double to compare. This is the double the unit test produced.</param><param name="delta">The required inaccuracy. The assertion will fail only if <paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/> or different from it by less than <paramref name="delta"/>.</exception>
        public static void AreNotEqual(double notExpected, double actual, double delta, string message, params object[] parameters)
        {
            if (Math.Abs(notExpected - actual) > delta)
                return;
            Assert.HandleFail("Assert.AreNotEqual", string.Format("Expected a difference greater than &lt;{3}&gt; between expected value &lt;{1}&gt; and actual value &lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), notExpected.ToString(CultureInfo.CurrentCulture.NumberFormat), actual.ToString(CultureInfo.CurrentCulture.NumberFormat), delta.ToString(CultureInfo.CurrentCulture.NumberFormat)), parameters);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified. The assertion fails if they are not equal.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase)
        {
            Assert.AreEqual(expected, actual, ignoreCase, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified. The assertion fails if they are not equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase, string message)
        {
            Assert.AreEqual(expected, actual, ignoreCase, message, null);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified. The assertion fails if they are not equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase, string message, params object[] parameters)
        {
            Assert.AreEqual(expected, actual, ignoreCase, CultureInfo.InvariantCulture, message, parameters);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are not equal.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture)
        {
            Assert.AreEqual(expected, actual, ignoreCase, culture, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are not equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message)
        {
            Assert.AreEqual(expected, actual, ignoreCase, culture, message, null);
        }

        /// <summary>
        /// Verifies that two specified strings are equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are not equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="expected">The first string to compare. This is the string the unit test expects.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="expected"/> is not equal to <paramref name="actual"/>.</exception>
        public static void AreEqual(string expected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            Assert.CheckParameterNotNull(culture, "Assert.AreEqual", "culture", string.Empty);
            if (string.Compare(expected, actual, ignoreCase, culture) == 0)
                return;
            Assert.HandleFail("Assert.AreEqual", ignoreCase || string.Compare(expected, actual, true, culture) != 0 ? string.Format("Expected:&lt;{1}&gt;. Actual:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(expected), Assert.ReplaceNulls(actual)) : string.Format("Expected:&lt;{1}&gt;. Case is different for actual value:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(expected), Assert.ReplaceNulls(actual)), parameters);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified. The assertion fails if they are equal.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified. The assertion fails if they are equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, message, null);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified. The assertion fails if they are equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, string message, params object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, CultureInfo.InvariantCulture, message, parameters);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are equal.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, string.Empty, null);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are equal. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message, null);
        }

        /// <summary>
        /// Verifies that two specified strings are not equal, ignoring case or not as specified, and using the culture info specified. The assertion fails if they are equal. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="notExpected">The first string to compare. This is the string the unit test expects not to match <paramref name="actual"/>.</param><param name="actual">The second string to compare. This is the string the unit test produced.</param><param name="ignoreCase">A Boolean value that indicates a case-sensitive or insensitive comparison. true indicates a case-insensitive comparison.</param><param name="culture">A <see cref="T:System.Globalization.CultureInfo"/> object that supplies culture-specific comparison information.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="notExpected"/> is equal to <paramref name="actual"/>.</exception>
        public static void AreNotEqual(string notExpected, string actual, bool ignoreCase, CultureInfo culture, string message, params object[] parameters)
        {
            Assert.CheckParameterNotNull(culture, "Assert.AreNotEqual", "culture", string.Empty);
            if (string.Compare(notExpected, actual, ignoreCase, culture) != 0)
                return;
            Assert.HandleFail("Assert.AreNotEqual", string.Format("Expected any value except:&lt;{1}&gt;. Actual:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), Assert.ReplaceNulls(notExpected), Assert.ReplaceNulls(actual)), parameters);
        }

        /// <summary>
        /// Verifies that the specified object is an instance of the specified type. The assertion fails if the type is not found in the inheritance hierarchy of the object.
        /// </summary>
        /// <param name="value">The object to verify is of <paramref name="expectedType"/>.</param><param name="expectedType">The type expected to be found in the inheritance hierarchy of <paramref name="value"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null or <paramref name="expectedType"/> is not found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsInstanceOfType(object value, Type expectedType)
        {
            Assert.IsInstanceOfType(value, expectedType, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified object is an instance of the specified type. The assertion fails if the type is not found in the inheritance hierarchy of the object. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="value">The object to verify is of <paramref name="expectedType"/>.</param><param name="expectedType">The type expected to be found in the inheritance hierarchy of <paramref name="value"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null or <paramref name="expectedType"/> is not found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsInstanceOfType(object value, Type expectedType, string message)
        {
            Assert.IsInstanceOfType(value, expectedType, message, null);
        }

        /// <summary>
        /// Verifies that the specified object is an instance of the specified type. The assertion fails if the type is not found in the inheritance hierarchy of the object. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="value">The object to verify is of <paramref name="expectedType"/>.</param><param name="expectedType">The type expected to be found in the inheritance hierarchy of <paramref name="value"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is null or <paramref name="expectedType"/> is not found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsInstanceOfType(object value, Type expectedType, string message, params object[] parameters)
        {
            if (expectedType == null)
                Assert.HandleFail("Assert.IsInstanceOfType", message, parameters);
            if (expectedType.IsInstanceOfType(value))
                return;
            Assert.HandleFail("Assert.IsInstanceOfType", string.Format("{0} Expected type:&lt;{1}&gt;. Actual type:&lt;{2}&gt;.", message == null ? string.Empty : Assert.ReplaceNulls(message), expectedType.ToString(), value == null ? "(null)" : value.GetType().ToString()), parameters);
        }

        /// <summary>
        /// Verifies that the specified object is not an instance of the specified type. The assertion fails if the type is found in the inheritance hierarchy of the object.
        /// </summary>
        /// <param name="value">The object to verify is not of <paramref name="wrongType"/>.</param><param name="wrongType">The type that should not be found in the inheritance hierarchy of <paramref name="value"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null and <paramref name="wrongType"/> is found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsNotInstanceOfType(object value, Type wrongType)
        {
            Assert.IsNotInstanceOfType(value, wrongType, string.Empty, null);
        }

        /// <summary>
        /// Verifies that the specified object is not an instance of the specified type. The assertion fails if the type is found in the inheritance hierarchy of the object. Displays a message if the assertion fails.
        /// </summary>
        /// <param name="value">The object to verify is not of <paramref name="wrongType"/>.</param><param name="wrongType">The type that should not be found in the inheritance hierarchy of <paramref name="value"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results. </param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null and <paramref name="wrongType"/> is found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsNotInstanceOfType(object value, Type wrongType, string message)
        {
            Assert.IsNotInstanceOfType(value, wrongType, message, null);
        }

        /// <summary>
        /// Verifies that the specified object is not an instance of the specified type. The assertion fails if the type is found in the inheritance hierarchy of the object. Displays a message if the assertion fails, and applies the specified formatting to it.
        /// </summary>
        /// <param name="value">The object to verify is not of <paramref name="wrongType"/>.</param><param name="wrongType">The type that should not be found in the inheritance hierarchy of <paramref name="value"/>.</param><param name="message">A message to display if the assertion fails. This message can be seen in the unit test results. </param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"><paramref name="value"/> is not null and <paramref name="wrongType"/> is found in the inheritance hierarchy of <paramref name="value"/>.</exception>
        public static void IsNotInstanceOfType(object value, Type wrongType, string message, params object[] parameters)
        {
            if (wrongType == null)
                Assert.HandleFail("Assert.IsNotInstanceOfType", message, parameters);
            if (value == null || !wrongType.IsInstanceOfType(value))
                return;
            Assert.HandleFail("Assert.IsNotInstanceOfType", string.Format("Wrong Type:&lt;{1}&gt;. Actual type:&lt;{2}&gt;. {0}", message == null ? string.Empty : Assert.ReplaceNulls(message), wrongType.ToString(), value.GetType().ToString()), parameters);
        }

        /// <summary>
        /// Fails the assertion without checking any conditions.
        /// </summary>
        /// <exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException">Always thrown.</exception>
        public static void Fail()
        {
            Assert.Fail(string.Empty, null);
        }

        /// <summary>
        /// Fails the assertion without checking any conditions. Displays a message.
        /// </summary>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException">Always thrown.</exception>
        public static void Fail(string message)
        {
            Assert.Fail(message, null);
        }

        /// <summary>
        /// Fails the assertion without checking any conditions. Displays a message, and applies the specified formatting to it.
        /// </summary>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException">Always thrown.</exception>
        public static void Fail(string message, params object[] parameters)
        {
            Assert.HandleFail("Assert.Fail", message, parameters);
        }

        /// <summary>
        /// Indicates that the assertion cannot be verified.
        /// </summary>
        /// <exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">Always thrown.</exception>
        public static void Inconclusive()
        {
            Assert.Inconclusive(string.Empty, null);
        }

        /// <summary>
        /// Indicates that the assertion can not be verified. Displays a message.
        /// </summary>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">Always thrown.</exception>
        public static void Inconclusive(string message)
        {
            Assert.Inconclusive(message, null);
        }

        /// <summary>
        /// Indicates that an assertion can not be verified. Displays a message, and applies the specified formatting to it.
        /// </summary>
        /// <param name="message">A message to display. This message can be seen in the unit test results.</param><param name="parameters">An array of parameters to use when formatting <paramref name="message"/>.</param><exception cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException">Always thrown.</exception>
        public static void Inconclusive(string message, params object[] parameters)
        {
            string str = string.Empty;
            if (!string.IsNullOrEmpty(message))
                str = parameters != null ? string.Format(Assert.ReplaceNulls(message), parameters) : Assert.ReplaceNulls(message);
            throw new AssertInconclusiveException(string.Format("{0} failed. {1}", "Assert.Inconclusive", str));
        }

        /// <summary>
        /// Determines whether two objects are equal.
        /// </summary>
        /// <param name="objA">An object that can be cast to an <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.Assert"/> instance.</param><param name="objB">An object that can be cast to an <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.Assert"/> instance.</param>
        public new static bool Equals(object objA, object objB)
        {
            Assert.Fail("Assert.Equals should not be used for Assertions. Please use Assert.AreEqual &amp; overloads instead.");
            return false;
        }

        internal static void HandleFail(string assertionName, string message, params object[] parameters)
        {
            string completeMessage = Assert.CreateCompleteMessage(message, parameters);
            Assert.HandleFailure(assertionName, completeMessage);
        }

        internal static string CreateCompleteMessage(string message, params object[] parameters)
        {
            string str = string.Empty;
            if (!string.IsNullOrEmpty(message))
                str = parameters != null ? string.Format(Assert.ReplaceNulls(message), parameters) : Assert.ReplaceNulls(message);
            return str;
        }

        internal static void HandleFailure(string assertionName, string message)
        {
            if (Assert.AssertionFailure != null)
                Assert.AssertionFailure(null, EventArgs.Empty);
            throw new AssertFailedException(string.Format("{0} failed. {1}", assertionName, message));
        }

        internal static void CheckParameterNotNull(object param, string assertionName, string parameterName, string message, params object[] parameters)
        {
            if (param != null)
                return;
            Assert.HandleFail(assertionName, string.Format("The parameter '{0}' is invalid. The value cannot be null. {1}.", parameterName, message), parameters);
        }

        internal static string ReplaceNulls(object input)
        {
            if (input == null)
                return "(null)";
            string input1 = input.ToString();
            if (input1 == null)
                return "(object)";
            return Assert.ReplaceNullChars(input1);
        }

        /// <summary>
        /// In a string, replaces null characters ('\0') with "\\0".
        /// </summary>
        /// 
        /// <returns>
        /// The converted string with null characters replaced by "\\0".
        /// </returns>
        /// <param name="input">The string in which to search for and replace null characters. </param>
        public static string ReplaceNullChars(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;
            List<int> list = new List<int>();
            for (int index = 0; index < input.Length; ++index)
            {
                if (input[index] == 0)
                    list.Add(index);
            }
            if (list.Count <= 0)
                return input;
            StringBuilder stringBuilder = new StringBuilder(input.Length + list.Count);
            int startIndex = 0;
            foreach (int num in list)
            {
                stringBuilder.Append(input.Substring(startIndex, num - startIndex));
                stringBuilder.Append("\\0");
                startIndex = num + 1;
            }
            stringBuilder.Append(input.Substring(startIndex));
            return stringBuilder.ToString();
        }
    }
}
