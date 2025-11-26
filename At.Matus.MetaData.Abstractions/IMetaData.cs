/*
 * At.Matus.MetaData.Abstractions.IMetaData
 *
 * Lightweight abstraction for a metadata container represented as a single record.
 * The record is a dictionary of string key/value pairs that stores all metadata entries.
 *
 * Responsibilities:
 * - `Records` exposes the stored metadata as a single `Dictionary<string, string>`.
 *   Implementations should avoid returning internal mutable collections directly — prefer
 *   defensive copies or read-only wrappers.
 * - `RecordCount` returns the number of metadata entries (i.e., the number of key/value pairs).
 * - `AddRecord(string key, string value)` adds a metadata entry to the dictionary;
 *   exact behavior for duplicate keys (overwrite, ignore, or throw) is implementation-defined
 *   and should be documented by concrete implementations. A common approach is to overwrite
 *   an existing value for the same key.
 *
 * Notes for implementers:
 * - This interface does not make thread-safety guarantees; document thread-safety in implementations.
 * - Validate arguments (e.g., throw ArgumentNullException) where appropriate.
 * - Keep the surface minimal and document how consumers should enumerate and modify entries.
 *
 * Target: .NET Framework 4.7.2, C# 7.3
 */

using System.Collections.Generic;

namespace At.Matus.MetaData.Abstractions
{
    public interface IMetaData
    {
        Dictionary<string, string> Records { get; }
        int RecordCount { get; }

        void AddRecord(string key, string value);
    }
}
