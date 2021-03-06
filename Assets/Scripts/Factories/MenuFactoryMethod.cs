﻿using UnityEngine;
using System.Collections;

public class MenuFactoryMethod:MonoBehaviour {

	public static GameObject createConfrimationGameMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/ConfrimationGameMenu")as GameObject);
	}
	public static GameObject createConfrimationMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/ConfrimationMenu")as GameObject);
	}
	public static GameObject createInstructionsGameMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/InstructionsGameMenu")as GameObject);
	}
	public static GameObject createInstructionsMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/InstructionsMenu")as GameObject);
	}
	public static GameObject createLogInMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/LogInMenuPrefab")as GameObject);
	}
	public static GameObject createLogInOption(){
		return Instantiate (Resources.Load("Prefabs/Menu/LogInOption")as GameObject);
	}
	public static GameObject createMainMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/MainMenuPrefab")as GameObject);
	}
	public static GameObject createPauseMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/PauseMenu")as GameObject);
	}
	public static GameObject createScroesMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/ScroesMenu")as GameObject);
	}
	public static GameObject createSignUpOption(){
		return Instantiate (Resources.Load("Prefabs/Menu/SignUpOption")as GameObject);
	}
	public static GameObject createWarningMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/WarningMenu")as GameObject);
	}
	public static GameObject createWinnerMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/WinMenu")as GameObject);
	}
	public static GameObject createLostMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/LostMenu")as GameObject);
	}
	public static GameObject createWaitMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/WaitMenu")as GameObject);
	}
	public static GameObject createTieMenu(){
		return Instantiate (Resources.Load("Prefabs/Menu/TieMenu")as GameObject);
	}
}
