// <copyright file="DebuggingTest.cs">Copyright ©  2020</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductivityFeatures;

namespace ProductivityFeatures.Tests
{
    /// <summary>This class contains parameterized unit tests for Debugging</summary>
    [PexClass(typeof(Debugging))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DebuggingTest
    {
        /// <summary>Test stub for debug2()</summary>
        [PexMethod]
        public void debug2Test()
        {
            Debugging.debug2();
            // TODO: add assertions to method DebuggingTest.debug2Test()
        }
    }
}
