using System.ComponentModel.DataAnnotations;
using System.Reflection;

static public class EnumExtensions
{
    public static string GetDisplayName(this Enum enumValue)
    {
        var memberInfo = enumValue.GetType()
                                  .GetMember(enumValue.ToString())
                                  .FirstOrDefault();

        if (memberInfo == null)
        {
            return enumValue.ToString();  // Return enum name as fallback
        }

        var displayAttribute = memberInfo.GetCustomAttribute<DisplayAttribute>();
        return displayAttribute?.GetName() ?? enumValue.ToString();  // Fallback to enum value name if no DisplayAttribute
    }
}
