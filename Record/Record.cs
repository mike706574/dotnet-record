using System;
using System.Collections.Generic;
using System.Linq;

namespace Mike.Data
{
    public class Record : Dictionary<string, object>
    {
        private IDictionary<string, object> _metadata;

        /// <summary>
        /// Creates an empty reocrd.
        /// </summary>
        public Record()
        {
            _metadata = null;
        }

        /// <summary>
        /// Creates a record from a dictionary.
        /// </summary>
        /// <param name="dictionary">A dictionary.</param>
        public Record(IDictionary<string, object> dictionary) : base(dictionary)
        {
            _metadata = null;
        }

        /// <summary>
        /// Creates a record from a dictionary with the given metadata.
        /// </summary>
        /// <param name="dictionary">A dictionary.</param>
        /// <param name="metadata">A metadata dictionary.</param>
        public Record(IDictionary<string, object> dictionary, IDictionary<string, object> metadata) : base(dictionary)
        {
            _metadata = metadata == null ? null : new Dictionary<string, object>(metadata);
        }

        /// <summary>
        /// Creates a record from a dictionary whose values are of an arbitrary type.
        /// </summary>
        /// <param name="dictionary">A dictionary.</param>
        /// <typeparam name="T">An arbitrary type.</typeparam>
        /// <returns>A record.</returns>
        public static Record Of<T>(IDictionary<string, T> dictionary)
        {
            Record record = new Record();
            record.AddAll(dictionary);
            return record;
        }

        /// <summary>
        /// Add all entries from the given dictionary to the record.
        /// </summary>
        /// <param name="dictionary">A dictionary.</param>
        /// <typeparam name="T">A type.</typeparam>
        /// <returns>A record.</returns>
        public Record AddAll<T>(IDictionary<string, T> dictionary)
        {
            foreach (KeyValuePair<string, T> entry in dictionary)
            {
                Add(entry.Key, entry.Value);
            }

            return this;
        }

        /// <summary>
        /// Returns an empty record.
        /// </summary>
        /// <returns>An empty record.</returns>
        public static Record Empty()
        {
            return new Record();
        }

        /// <summary>
        /// Returns an empty record with the given metadata.
        /// </summary>
        /// <param name="metadata">A metadata dictionary.</param>
        /// <returns>An empty dictionary with the given metadata.</returns>
        public static Record Empty(IDictionary<string, object> metadata)
        {
            return new Record(new Dictionary<string, object>(), metadata);
        }

        /// <summary>
        /// Returns a record containing the given keys and values. Takes an
        /// alternating sequence of keys and values.
        /// </summary>
        /// <param name="k1">A key.</param>
        /// <param name="v1">A value.</param>
        /// <returns>A record containing the given keys and values.</returns>
        public static Record Of(string k1, object v1)
        {
            Record record = new Record();
            record.Add(k1, v1);
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2)
        {
            Record record = new Record {{k1, v1}, {k2, v2}};
            return record;
        }


        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}, {k4, v4}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}, {k4, v4}, {k5, v5}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}, {k4, v4}, {k5, v5}, {k6, v6}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}, {k4, v4}, {k5, v5}, {k6, v6}, {k7, v7}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8)
        {
            Record record = new Record {{k1, v1}, {k2, v2}, {k3, v3}, {k4, v4}, {k5, v5}, {k6, v6}, {k7, v7}, {k8, v8}};
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15, string k16, object v16)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15},
                {k16, v16}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15, string k16, object v16,
            string k17, object v17)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15},
                {k16, v16},
                {k17, v17}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15, string k16, object v16,
            string k17, object v17, string k18, object v18)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15},
                {k16, v16},
                {k17, v17},
                {k18, v18}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15, string k16, object v16,
            string k17, object v17, string k18, object v18,
            string k19, object v19)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15},
                {k16, v16},
                {k17, v17},
                {k18, v18},
                {k19, v19}
            };
            return record;
        }

        public static Record Of(string k1, object v1, string k2, object v2,
            string k3, object v3, string k4, object v4,
            string k5, object v5, string k6, object v6,
            string k7, object v7, string k8, object v8,
            string k9, object v9, string k10, object v10,
            string k11, object v11, string k12, object v12,
            string k13, object v13, string k14, object v14,
            string k15, object v15, string k16, object v16,
            string k17, object v17, string k18, object v18,
            string k19, object v19, string k20, object v20)
        {
            Record record = new Record
            {
                {k1, v1},
                {k2, v2},
                {k3, v3},
                {k4, v4},
                {k5, v5},
                {k6, v6},
                {k7, v7},
                {k8, v8},
                {k9, v9},
                {k10, v10},
                {k11, v11},
                {k12, v12},
                {k13, v13},
                {k14, v14},
                {k15, v15},
                {k16, v16},
                {k17, v17},
                {k18, v18},
                {k19, v19},
                {k20, v20}
            };
            return record;
        }

        public static Record Of(params object[] kvs)
        {
            Record record = new Record();
            for (int i = 0; i < kvs.Length; i += 2)
            {
                string k = (string) kvs[i];
                object v = kvs[i + 1];
                record.Add(k, v);
            }

            return record;
        }

        /// <summary>
        /// Returns the string value to which the specified key is mapped, or null
        /// if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <returns>Returns the string value to which the specified key is
        /// mapped, or null if this record contains no mapping for the key.
        /// </returns>
        /// <exception cref="TypeMismatchException">Thrown when the value
        /// mapped to the key is not a string.</exception>
        public string GetString(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (found)
            {
                if (value == null)
                {
                    return null;
                }

                if (value is string)
                {
                    return (string) value;
                }

                throw new TypeMismatchException(key, value, "string", value.GetType().Name);
            }

            return null;
        }

        /// <summary>
        /// Returns the integer value to which the specified key is mapped, or
        /// null if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <returns>Returns the integer value to which the specified key is
        /// mapped, or null if this record contains no mapping for the key.
        /// </returns>
        /// <exception cref="TypeMismatchException">Thrown when the value
        /// mapped to the key is not an integer.</exception>
        public int? GetInteger(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (found)
            {
                if (value == null)
                {
                    return null;
                }

                if (value is int)
                {
                    return (int) value;
                }

                throw new TypeMismatchException(key, value, "integer", value.GetType().Name);
            }

            return null;
        }

        /// <summary>
        /// Returns the list value to which the specified key is mapped, or
        /// null if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <typeparam name="T">A type.</typeparam>
        /// <returns>Returns the list value to which the specified key is
        /// mapped, or null if this record contains no mapping for the key.
        /// </returns>
        /// <exception cref="TypeMismatchException">Thrown when the value
        /// mapped to the key is not a list.</exception>
        public IList<T> GetList<T>(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (found)
            {
                if (value == null)
                {
                    return null;
                }

                if (value is List<T> list)
                {
                    return list;
                }

                throw new TypeMismatchException(key, value, "list", value.GetType().Name);
            }

            return null;
        }

        /**
         * Returns the dictionary value to which the specified key is mapped, or
         * null if this map contains no mapping for the key. Throws a
         * TypeMismatchException if the value mapped to the key is not a
         * dictionary.
         */

        /// <summary>
        /// Returns the dictionary value to which the specified key is mapped,
        /// or null if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <typeparam name="TK">The key type.</typeparam>
        /// <typeparam name="TV">The key type.</typeparam>
        /// <returns>Returns the dictionary value to which the specified key is
        /// mapped, or null if this record contains no mapping for the key.
        /// </returns>
        /// <exception cref="TypeMismatchException">Thrown when the value
        /// mapped to the key is not a dictionary.</exception>
        public IDictionary<TK, TV> GetDictionary<TK, TV>(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (!found) return null;
            switch (value)
            {
                case null: return null;
                case Dictionary<TK, TV> dict: return dict;
            }

            throw new TypeMismatchException(key, value, "dictionary", value.GetType().Name);
        }

        /// <summary>
        /// Returns the record value to which the specified key is mapped, or
        /// null if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <returns>A record.</returns>
        /// <exception cref="TypeMismatchException">Thrown when the value
        /// mapped to the given key is not a record.</exception>
        public Record GetRecord(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (!found) return null;
            switch (value)
            {
                case null: return null;
                case Record _: return (Record) value;
            }

            throw new TypeMismatchException(key, value, "record", value.GetType().Name);
        }

        /// <summary>
        /// Returns the value of the given type to which the specified key is
        /// mapped, or null if this record contains no mapping for the key.
        /// </summary>
        /// <param name="key">A key.</param>
        /// <typeparam name="T">A type.</typeparam>
        /// <returns>A value of the given type, or null if this record contains
        /// no mapping for the key.</returns>
        /// <exception cref="TypeMismatchException">Thrown when the value mapped
        /// to the given key is not of the given type.</exception>
        public T Get<T>(string key)
        {
            bool found = TryGetValue(key, out object value);

            if (!found) return default(T);
            switch (value)
            {
                case null: return default(T);
                case T _: return (T) value;
            }

            throw new TypeMismatchException(key, value, typeof(T).Name, value.GetType().Name);
        }

        /// <summary>
        /// Returns a new record with the given keys and values added.
        /// </summary>
        /// <param name="k1">A key.</param>
        /// <param name="v1">A value.</param>
        /// <returns>A new record with the given keys and values added.</returns>
        public Record Assoc(string k1, object v1)
        {
            Record record = new Record();
            record.AddAll(this);
            record.Add(k1, v1);
            return record;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            bool bothRecords = obj.GetType() == GetType();
            bool isGenericDictionary = IsGenericDictionary(obj);
            return (bothRecords || isGenericDictionary) && Equals((IDictionary<string, object>) obj);
        }

        private static bool IsGenericDictionary(object obj)
        {
            Type type = obj.GetType();
            return type.IsGenericType &&
                   type.GetGenericTypeDefinition() == typeof(Dictionary<,>) &&
                   type.GetGenericArguments().Length == 2 &&
                   type.GetGenericArguments()[0] == typeof(string) &&
                   type.GetGenericArguments()[1] == typeof(object);
        }

        public override string ToString()
        {
            string entries = this.Select(entry => $"{entry.Key}={entry.Value}")
                .Aggregate((current, next) => current + ", " + next);
            return '{' + entries + '}';
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private bool Equals(IDictionary<string, object> other)
        {
            if (Count != other.Count) return false;
            foreach (KeyValuePair<string, object> pair in other)
            {
                if (other.TryGetValue(pair.Key, out object value))
                {
                    if (!value.Equals(pair.Value))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}