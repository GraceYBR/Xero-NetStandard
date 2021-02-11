/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing Timesheet
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TimesheetTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Theory]
        [InlineData("APPROVED", TimesheetStatus.APPROVED)]
        [InlineData("DRAFT", TimesheetStatus.DRAFT)]
        [InlineData("PROCESSED", TimesheetStatus.PROCESSED)]
        [InlineData("REJECTED", TimesheetStatus.REJECTED)]
        [InlineData("REQUESTED", TimesheetStatus.REQUESTED)]
        public void StatusTest(string input, TimesheetStatus expected)
        {
            JsonDoc.Assert<Timesheet, TimesheetStatus>(
                input: new JsonDoc.String(nameof(Timesheet.Status), input),
                toProperty: x => x.Status,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'Hours'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void HoursTest(string input)
        {
            JsonDoc.Assert<Timesheet, decimal?>(
                input: new JsonDoc.Number(nameof(Timesheet.Hours), input),
                toProperty: x => x.Hours,
                shouldBe: 20
            );
        }
    }
}