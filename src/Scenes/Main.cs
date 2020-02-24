using Godot;
using System;

public class Main : Control
{
	private Label titleLabel;
	private GameManager gameManager;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		titleLabel = GetNode<Label>("Title");
		gameManager = GetNode<GameManager>("/root/GameManager");
	}
	
	private void _on_PlayButton_button_up()
	{
		GD.Print("new game from main menu");
		gameManager.newGame();
	}

	private void _on_QuitButton_button_up()
	{
		GD.Print("player wants to quit from main menu");
		// TODO: prompt "are you sure?"
		// TODO: quit game completely
		GetTree().Quit();
	}
}