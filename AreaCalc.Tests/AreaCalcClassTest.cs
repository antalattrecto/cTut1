// <copyright file="AreaCalcClassTest.cs">Copyright ©  2019</copyright>
using System;
using AreaCalc;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalc.Tests
{
    /// <summary>This class contains parameterized unit tests for AreaCalcClass</summary>
    [PexClass(typeof(AreaCalcClass))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AreaCalcClassTest
    {
        
    }
}
