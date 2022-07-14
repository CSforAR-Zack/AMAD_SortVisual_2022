namespace SortVisual;

public abstract class Sorter
{
    protected Values values = null;

    public Sorter(Values values)
    {
        this.values = values;
    }

    public abstract void Sort();

    public void Swap(int i, int j)
    {
        Label temp = values.Labels[i];
        values.Labels[i] = values.Labels[j];
        values.Labels[j] = temp;
    }
}
