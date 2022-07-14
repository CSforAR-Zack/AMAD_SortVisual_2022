namespace SortVisual;

public class InsertionSort : Sorter
{
    public InsertionSort(Values values) : base(values)
    {
    }

    public override void Sort()
    {
        for (int j = 0; j < this.values.Labels.Count; j++)
        {
            int k = j - 1;
            while ((k >= 0) && Convert.ToInt32(this.values.Labels[k].Text) > Convert.ToInt32(this.values.Labels[k + 1].Text))
            {
                this.Swap(k, k + 1);
                k--;
            }
        }
        this.values.Draw();
    }
}
