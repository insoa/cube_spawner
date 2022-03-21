using System.Collections;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public sealed class Cube : MonoBehaviour {
	
	private float _speed;
	private float _distance;
	private float _timeToDelete;
	private Vector3 _endPos;
	
	private void Start() {
		GetData();
		_endPos = new Vector3(_distance, transform.position.y, 0f);
	}

	private void Update() {
		transform.position = Vector3.MoveTowards(transform.position, _endPos, _speed * Time.deltaTime);
		if (transform.position == _endPos)
			StartCoroutine(DeleteObject());
	}

	private void GetData() {
		_speed = float.Parse(InputPanel.Instance.InputSpeed.text);
		_distance = float.Parse(InputPanel.Instance.InputDistance.text);
		_timeToDelete = float.Parse(InputPanel.Instance.InputTimeToSpawn.text);
	}

	private IEnumerator DeleteObject() {
		yield return new WaitForSeconds(_timeToDelete);
		Destroy(gameObject);
	}
}