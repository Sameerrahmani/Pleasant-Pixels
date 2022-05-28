using Godot;
using System;

public class GameScene : Node2D
{
	public Label OnOff;
	public Label RainOnOff;
	public AudioStreamPlayer2D AmbiancePlayer;
	public AudioStreamPlayer2D MusicPlayer;
	
	public override void _Ready()
	{
		MusicPlayer = GetNode<AudioStreamPlayer2D>("Control/MusicPlayer");
		AmbiancePlayer = GetNode<AudioStreamPlayer2D>("Control/AmbiancePlayer");
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
		
	}
}












