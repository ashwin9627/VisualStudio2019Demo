// <copyright file="IntelliTestTest.cs">Copyright ©  2020</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualStudioDemo.Models;

namespace VisualStudioDemo.Models.Tests
{
    /// <summary>This class contains parameterized unit tests for IntelliTest</summary>
    [PexClass(typeof(IntelliTest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class IntelliTestTest
    {
        /// <summary>Test stub for Test(Int32, Int32)</summary>
        [PexMethod]
        public void TestTest(
            [PexAssumeUnderTest]IntelliTest target,
            int a,
            int b
        )
        {
            target.Test(a, b);
            // TODO: add assertions to method IntelliTestTest.TestTest(IntelliTest, Int32, Int32)
        }
    }
}
