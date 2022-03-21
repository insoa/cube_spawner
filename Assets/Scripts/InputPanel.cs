using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class InputPanel : MonoBehaviour {

	#region Singleton

	public static InputPanel Instance;
	private void Awake() => Instance = this;

	#endregion

	public TMP_InputField InputSpeed;
	public TMP_InputField InputDistance;
	public TMP_InputField InputTimeToSpawn;
	public Button StartButton;
}