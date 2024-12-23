using Godot;
using System;

public partial class Node2d : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// example function just get the node sprite2d and print the positions x and y
		var sprite = GetNode<Sprite2D>("Icon");
		Console.WriteLine($"Node2d Ready {sprite.Position.X} {sprite.Position.Y}");

		var sumOfPositions = sumTwoValues(sprite.Position.X, sprite.Position.Y);
		Console.WriteLine($"Node2d Ready sum of positions {sumOfPositions}");

		var subOfPositions = subTwoValues(sprite.Position.X, sprite.Position.Y);
		Console.WriteLine($"Node2d Ready sub of positions {subOfPositions}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public float subTwoValues(float a, float b)
	{
		return a - b;
	}

	public float sumTwoValues(float a, float b)
	{
		return a + b;
	}
}
