namespace SortVisual;

public partial class SortPage : ContentPage
{
	int numValues = 50;
	Values values = null;
	InsertionSort iSort = null;

	public SortPage()
	{
		InitializeComponent();
		this.values = new Values(numValues, hsl);
		this.iSort = new InsertionSort(values);
	}

	void GenerateValues(object sender, EventArgs args)
	{
		this.values.GenerateValues();
	}

	void InsertSort(object sender, EventArgs args)
	{
		iSort.Sort();
	}

}