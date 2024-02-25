using Godot;
using System;

public partial class EmployeeSimple : NavigationAgent2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		TargetPosition = new Vector2(917, 854);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
