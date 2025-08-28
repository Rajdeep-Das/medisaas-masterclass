using System.Collections.Generic;
using System.Reflection;

public static class PhiScanner
{
    public static IEnumerable<(string PropertyName, object? Value, string? Reason)> GetPhiFields(object obj)
    {
        if (obj == null) yield break;
        var props = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var p in props)
        {
            var attr = p.GetCustomAttribute<PhiAttribute>();
            if (attr != null)
            {
                var val = p.GetValue(obj);
                yield return (p.Name, val, attr.Reason);
            }
        }
    }
}
