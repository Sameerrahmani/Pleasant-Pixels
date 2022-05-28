using Godot;
using System;

public class GameScene : Node2D
{
	public Panel ControlPanel;
	public AudioStreamPlayer2D AmbiancePlayer;
	public AudioStreamPlayer2D MusicPlayer;
	public Panel EscapePanel;
	public RichTextLabel Time;
	
	public override void _Ready()
	{
		MusicPlayer = GetNode<AudioStreamPlayer2D>("Control/MusicPlayer");
		AmbiancePlayer = GetNode<AudioStreamPlayer2D>("Control/AmbiancePlayer");
		ControlPanel = GetNode<Panel>("Control/Panel");
		EscapePanel = GetNode<Panel>("Control/Panel2");
		Time = GetNode<RichTextLabel>("Control/Time");
		
		
		
		
	}
	
	public override void _Process(float delta)
	{
		var time = OS.GetTime();
		Time.Text = time.ToString();
	}
	

	private void _on_MusicButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			MusicPlayer.Playing = true;
		}
		
		else if (button_pressed == false)
		{
			MusicPlayer.Playing = false;
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
			EscapePanel.RectPosition = new Vector2(913, 740);
			ControlPanel.Visible = true;
		}
	}
	
	private void _on_ClockButton_toggled(bool button_pressed)
	{
		if (button_pressed == true)
		{
			Time.Visible = true;
		}
		
		else if (button_pressed == false)
		{
			Time.Visible = false;
		}
	}
}





