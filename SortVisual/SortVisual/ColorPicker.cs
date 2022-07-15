namespace SortVisual;

public static class ColorPicker
{
    //
    //Summary:
    //     This class allows us to set the color of a label to some defined colors.
    static Dictionary<string, Color> colors = new Dictionary<string, Color> 
    {
        {"sorted",  Color.FromArgb("#77ff77")},
        {"lookingAt", Colors.Cyan },
        {"unsorted", Colors.Grey },
        {"current", Colors.Yellow },
        {"best", Colors.Red }
    };

    public static void SetColor(Label label, string key)
    {
        label.BackgroundColor = colors[key];
    }
}
