using System.Globalization;

namespace ijs.Internal; 

internal static class BaseValueRounder {
    internal static double MultipleBaseValue(double baseValue, double magnitude) {
        return (double)Round(baseValue * magnitude);
    }

    internal static string GetRoundF2String(double value) {
        return Round(value).ToString("F2", CultureInfo.InvariantCulture);
    }

    static decimal Round(double value) => Math.Round((decimal)value, 2, MidpointRounding.AwayFromZero);
}
