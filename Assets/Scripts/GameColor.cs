using UnityEngine;

public class GameColor
{
    static readonly string[] hexArray = { "#ffffff", "#fff07c", "#f2be83", "#e58c8a", "#eec0c6", "#80ff72", "#7ee8fa" };

    public static Color Get(ref ColorValue value)
    {
        int colIndex = ToIndex(value);
        value = (ColorValue)colIndex;

        if (ColorUtility.TryParseHtmlString(hexArray[colIndex], out Color newCol))
            return newCol;

        value = ColorValue.white;
        return Color.white;
    }

    private static int ToIndex(ColorValue value) => (value == ColorValue.white) ? Random.Range(1, System.Enum.GetValues(typeof(ColorValue)).Length) : (int)value;
}

public enum ColorValue
{
    white,
    yellow,
    orange,
    red,
    pink,
    green,
    blue
}
