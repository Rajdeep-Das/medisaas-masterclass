using System;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public sealed class PhiAttribute : Attribute
{
    public string? Reason { get; }
    public PhiAttribute(string? reason = null)
    {
        Reason = reason;
    }
}