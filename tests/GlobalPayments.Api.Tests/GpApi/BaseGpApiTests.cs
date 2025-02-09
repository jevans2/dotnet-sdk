﻿using System;
using System.Threading;
using GlobalPayments.Api.Utils;

namespace GlobalPayments.Api.Tests.GpApi {
    public abstract class BaseGpApiTests {
        protected const string SUCCESS = "SUCCESS";
        protected const string DECLINED = "DECLINED";
        protected const string VERIFIED = "VERIFIED";
        protected const string CLOSED = "CLOSED";

        protected static string APP_ID = "x0lQh0iLV0fOkmeAyIDyBqrP9U5QaiKc";
        protected static string APP_KEY = "DYcEE2GpSzblo0ib";

        protected static string APP_ID_FOR_DCC = "mivbnCh6tcXhrc6hrUxb3SU8bYQPl9pd";
        protected static string APP_KEY_FOR_DCC = "Yf6MJDNJKiqObYAb";
        
        protected static string APP_ID_FOR_BATCH = "P3LRVjtGRGxWQQJDE345mSkEh2KfdAyg";
        protected static string APP_KEY_FOR_BATCH = "ockJr6pv6KFoGiZA";

        protected static readonly int expMonth = DateTime.Now.Month;
        protected static readonly int expYear = DateTime.Now.Year + 1;

        protected static readonly DateTime startDate = DateTime.UtcNow.AddDays(-30);
        protected static readonly DateTime endDate = DateTime.UtcNow;

        protected string GetMapping<T>(T value, Target target = Target.GP_API) where T : Enum {
            return EnumConverter.GetMapping(target, value);
        }

        protected void waitForGpApiReplication() {
            Thread.Sleep(2000);
        }
    }
}