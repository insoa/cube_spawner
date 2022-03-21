 using UnityEngine;

public sealed class CubeSpawner : MonoBehaviour {
	[SerializeField] private Cube _cubePrefab;

	private void Start() {
		InputPanel.Instance.StartButton.onClick.AddListener(SpawnObject);
	}

	private void SpawnObject() {
		Instantiate(_cubePrefab, new Vector3(-17f, 3f, 0f), Quaternion.identity);
	}
}