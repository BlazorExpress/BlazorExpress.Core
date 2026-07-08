

namespace BlazorExpress.Core;

/// <summary>
/// Various extension methods for <see cref="Type" />.
/// </summary>
public static partial class TypeExtensions
{
    #region Methods

    public static string? GetDisplayName(this Type type, string? name)
    {
        if (name is not null)
        {
            var attr = type!.GetMember(name).FirstOrDefault()?.GetCustomAttribute<DisplayAttribute>();
            name = attr?.GetName() ?? name;
        }

        return name;
    }

    #endregion
}
