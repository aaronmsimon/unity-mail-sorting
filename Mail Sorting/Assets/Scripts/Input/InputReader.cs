using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InputReader", menuName = "Game/Input Reader")]
public class InputReader : ScriptableObject, InputSettings.IGameplayActions
{
	// Gameplay
	public event UnityAction test1Event;

	private InputSettings inputSettings;

	private void OnEnable()
	{
		if (inputSettings == null)
		{
			inputSettings = new InputSettings();
			inputSettings.Gameplay.SetCallbacks(this);
		}

		EnableGameplayInput();
	}

	private void OnDisable()
	{
		DisableAllInput();
	}

	// Gameplay

	public void OnTest1(InputAction.CallbackContext context)
	{
		if (test1Event != null)
		{
			test1Event?.Invoke();
		}
	}

	// Enable/Disable

	public void EnableGameplayInput()
	{
		inputSettings.Gameplay.Enable();
	}

	public void DisableAllInput()
	{
		inputSettings.Gameplay.Disable();
	}
}