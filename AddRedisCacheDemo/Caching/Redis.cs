﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddRedisCacheDemo.Caching
{
    public class Redis
    {
        private readonly IDistributedCache _distributedCache;
        public Redis(IDistributedCache _distributedCache)
        {
            this._distributedCache = _distributedCache;
        }

        [HttpGet]
        public string Get()
        {
            var cacheKey = "The Time";
            var currentTime = DateTime.Now.ToString();
            var cachedTime = _distributedCache.GetString(cacheKey);
            if (string.IsNullOrEmpty(cachedTime))
            {
                // cachedTime = "Expired";
                // Cache expire trong 5s
                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(5));
                // Nạp lại giá trị mới cho cache
                _distributedCache.SetString(cacheKey, currentTime, options);
                cachedTime = _distributedCache.GetString(cacheKey);
            }
            var result = $"Current Time : {currentTime} \nCached  Time : {cachedTime}";
            return result;
        }
    }
}
