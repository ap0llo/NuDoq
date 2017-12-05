﻿#region Apache Licensed
/*
 Copyright 2013 Daniel Cazzulino

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
#endregion

namespace NuDoq
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Internal class used to cache the results of the enumeration of the 
    /// container elements.
    /// </summary>
    internal static class CachedEnumerable
    {
        public static IEnumerable<T> Cached<T>(this IEnumerable<T> enumerable)
        {
            return new CachedEnumerableImpl<T>(enumerable);
        }

        private class CachedEnumerableImpl<T> : IEnumerable<T>
        {
            private IEnumerator<T> enumerator;
            private IEnumerable<T> enumerable;
            private List<T> cache = new List<T>();

            public CachedEnumerableImpl(IEnumerable<T> enumerable)
            {
                this.enumerable = enumerable;
            }

            public IEnumerator<T> GetEnumerator()
            {
                // First time we'll get the enumerator, only 
                // once. Next time, it will already have a value
                // and so we won't enumerate twice ever.
                if (enumerator == null)
                    enumerator = enumerable.GetEnumerator();

                int index = 0;
                do
                {
                    if (index < cache.Count)
                        yield return cache[index];

                    else if (enumerator.MoveNext())
                    {
                        cache.Add(enumerator.Current);
                        yield return enumerator.Current;
                    }

                    index++;
                } while (index <= cache.Count);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}