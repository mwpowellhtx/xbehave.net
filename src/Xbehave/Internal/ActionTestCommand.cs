﻿// <copyright file="ActionTestCommand.cs" company="Adam Ralph">
//  Copyright (c) Adam Ralph. All rights reserved.
// </copyright>

namespace Xbehave.Internal
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Xunit.Sdk;

    internal class ActionTestCommand : TestCommand
    {
        private readonly Action action;

        public ActionTestCommand(IMethodInfo method, string name, int timeout, Action action)
            : base(method, name, timeout)
        {
            this.action = action;
        }

        // TODO: address DoNotCatchGeneralExceptionTypes - it seems like this is being done so that the test runner doesn't stop and continues to run teardowns
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Part of the original SubSpec code - will be addressed.")]
        public override MethodResult Execute(object testClass)
        {
            try
            {
                this.action();
            }
            catch (Exception ex)
            {
                return new FailedResult(testMethod, ex, DisplayName);
            }

            return new PassedResult(testMethod, DisplayName);
        }
    }
}