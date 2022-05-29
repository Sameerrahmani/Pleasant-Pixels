using Godot;
using System;

public class GameScene : Node2D
{
	public Panel ControlPanel;
	public AudioStreamPlayer2D AmbiancePlayer;
	public AudioStreamPlayer2D MusicPlayer1;
	public Panel EscapePanel;
	public Panel Clock;
	public AnimatedSprite AnimatedScene1;
	public AnimatedSprite AnimatedScene2;
	public Node2D Space;
	

	
	public override void _Ready()
	{
		MusicPlayer1 = GetNode<AudioStreamPlayer2D>("Control/MusicPlayer1");
		AmbiancePlayer = GetNode<AudioStreamPlayer2D>("Control/AmbiancePlayer");
		ControlPanel = GetNode<Panel>("Control/Panel");
		EscapePanel = GetNode<Panel>("Control/Panel2");
		Clock = GetNode<Panel>("Control/Panel3");
		AnimatedScene1 = GetNode<AnimatedSprite>("Control/AnimatedScene1");
		AnimatedScene2 = GetNode<AnimatedSprite>("Control/AnimatedScene2");
		Space = GetNode<Node2D>("Space");
		
	}
		

	private void _on_MusicButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			MusicPlayer1.Playing = true;
		}
		
		else if (button_pressed == false)
		{
			MusicPlayer1.Playing = false;
		}
	}
	
	private void _on_RainButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			AmbiancePlayer.Playing = true;
		}
		
		else if (button_pressed == false)
		{
			AmbiancePlayer.Playing = false;
		}
	}
	
	private void _on_TextureButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			EscapePanel.RectPosition = new Vector2(913, 1028);
			ControlPanel.Visible = false;
		}
		
		else if (button_pressed == false)
		{
			EscapePanel.RectPosition = new Vector2(913, 834);
			ControlPanel.Visible = true;
		}
	}
	
	private void _on_ClockButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			Clock.Visible = true;
		}
		
		else if (button_pressed == false)
		{
			Clock.Visible = false;
		}
	}
	
	private void _on_RainyBedroom_pressed()
	{
		AnimatedScene1.Visible = true;
		if (AnimatedScene2.Visible == true)
		{
			AnimatedScene2.Visible = false;
		}
		
		else if (Space.Visible == true)
		{
			Space.Visible = false;
		}
	}
	
	private void _on_RainyLake_pressed()
	{
		AnimatedScene2.Visible = true;
		if (AnimatedScene1.Visible == true)
		{
			AnimatedScene1.Visible = false;
		}
		
		else if (Space.Visible == true)
		{
			Space.Visible = false;
		}
	}
	
	private void _on_Space_pressed()
	{
		Space.Visible = true;
		if (AnimatedScene1.Visible == true)
		{
			AnimatedScene1.Visible = false;
		}
		
		else if (AnimatedScene2.Visible == true)
		{
			AnimatedScene2.Visible = false;
		}
	}
	
	private void _on_Lofi_pressed()
	{
		var Lofi = ResourceLoader.Load("res://Assets/Lofi.mp3") as AudioStream;
			
		MusicPlayer1.Stream = Lofi;
		MusicPlayer1.Play();
	}
	
	private void _on_Fantasy_pressed()
	{
		var Fantasy = ResourceLoader.Load("res://Assets/Now-We-Ride.mp3") as AudioStream;
			
		MusicPlayer1.Stream = Fantasy;
		MusicPlayer1.Play();
	}
	
	private void _on_Piano_pressed()
	{
		var Piano = ResourceLoader.Load("res://Assets/a-promise.mp3") as AudioStream;
		
		MusicPlayer1.Stream = Piano;
		MusicPlayer1.Play();
	}
}
































