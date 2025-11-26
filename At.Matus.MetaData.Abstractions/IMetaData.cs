/*
 * At.Matus.MetaData.Abstractions.IMetaData
 *
 * Lightweight abstraction for a metadata container composed of one or more records.
 * Each record is represented as a dictionary of string key/value pairs.
 *
 * Responsibilities:
 * - `Records` exposes the stored records (implementations should avoid returning
 *   internal mutable collections directly — prefer defensive copies or read-only wrappers).
 * - `RecordCount` returns the number of records.
 * - `AddRecord(string key, string value)` adds a key/value pair to the metadata store;
 *   exact behavior for record creation and duplicate-key handling is implementation-defined
 *   and should be documented by concrete implementations.
 *
 * Notes for implementers:
 * - This interface does not make thread-safety guarantees; document thread-safety in implementations.
 * - Validate arguments (e.g., throw ArgumentNullException) where appropriate.
 * - Keep the surface minimal and document how consumers should enumerate and modify records.
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
