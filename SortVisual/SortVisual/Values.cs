namespace SortVisual;

public class Values
{
    int numValues = 0;
    HorizontalStackLayout hsl = null;
    List<Label> labels = new List<Label>();
    Random random = new Random();

    public List<Label> Labels { get { return labels; } }

    public Values(int numValues, HorizontalStackLayout hsl)
    {
        this.numValues = numValues;
        this.hsl = hsl;
    }

    public void GenerateValues()
    {
        this.labels.Clear();
        for (int i = 0; i < numValues; i++)
        {
            Label label = new Label();
            int num = this.random.Next(1, 20);
            label.HeightRequest = num * 10;
            label.Text = num.ToString();
            this.labels.Add(label);
        }
        this.Draw();
    }

    public void Draw()
    {
        this.hsl.Clear();
        foreach (var label in this.labels)
        {
            this.hsl.Add(label);
        }
    }
}
