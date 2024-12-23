using GdUnit4;

[TestSuite]
public class Node2d_test
{
	[TestCase]
	public void TestSubTwoValues()
	{
		var node2d = new Node2d();
		var result = node2d.subTwoValues(2, 1);
		Assertions.AssertThat(result).IsEqual(1);
		node2d.Free();
	}

	[TestCase]
	public void TestSumTwoValues()
	{
		var node2d = new Node2d();
		var result = node2d.sumTwoValues(1, 2);
		Assertions.AssertThat(result).IsEqual(3);
		node2d.Free();
	}
}
