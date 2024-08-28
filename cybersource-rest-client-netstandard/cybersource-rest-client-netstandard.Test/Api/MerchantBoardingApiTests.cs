/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing MerchantBoardingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class MerchantBoardingApiTests
    {
        private MerchantBoardingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MerchantBoardingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MerchantBoardingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' MerchantBoardingApi
            //Assert.IsInstanceOfType(typeof(MerchantBoardingApi), instance, "instance is a MerchantBoardingApi");
        }

        
        /// <summary>
        /// Test GetRegistration
        /// </summary>
        [Test]
        public void GetRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string registrationId = null;
            //var response = instance.GetRegistration(registrationId);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        
        /// <summary>
        /// Test PostRegistration
        /// </summary>
        [Test]
        public void PostRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostRegistrationBody postRegistrationBody = null;
            //string vCIdempotencyId = null;
            //var response = instance.PostRegistration(postRegistrationBody, vCIdempotencyId);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
        
    }

}
