﻿using System;
using LaunchDarkly.Client;

namespace LaunchDarkly.Xamarin
{
    internal static class Extensions
    {
        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string AsJson(this User user)
        {
            return JsonUtil.EncodeJson(user);
        }
    }
}
