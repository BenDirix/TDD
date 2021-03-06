// <copyright file="Class1Test.cs">Copyright ©  2018</copyright>

using System;
using Intellitest;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Intellitest.Tests
{
    [TestClass]
    [PexClass(typeof(Class1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Class1Test
    {

        [PexMethod]
        public bool IsSchrikkelJaar([PexAssumeUnderTest]Class1 target, int jaar)
        {
            bool result = target.IsSchrikkelJaar(jaar);
            return result;
            // TODO: add assertions to method Class1Test.IsSchrikkelJaar(Class1, Int32)
        }
    }
}
