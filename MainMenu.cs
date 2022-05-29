using Godot;
using System;

public class MainMenu : Control
{
	public Button StartButton;
	public AnimationPlayer DayNight;
	
	public override void _Ready()
	{
		StartButton = GetNode<Button>("CanvasLayer/StartButton");
		DayNight = GetNode<AnimationPlayer>("CanvasModulate/AnimationPlayer");
		DayNight.Play("DayNightCycle");
		
	}

	private void _on_StartButton_pressed()
	{
		GetTree().ChangeScene("res://Scenes/GameScene.tscn");
	}

	private void _on_ExitButton_pressed()
	{
		GetTree().Quit();
	}
}




