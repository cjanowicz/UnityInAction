using UnityEngine;
using System.Collections;

public class sceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	 private GameObject _enemy;
	
	// Update is called once per frame
	void Update () {
		if (_enemy == null) {
			_enemy = Instantiate(enemyPrefab) as GameObject;
			Debug.Log ("Enemy created.");
			_enemy.transform.position = new Vector3(5,1,0);
			float angle = Random.Range(0,360);
			_enemy.transform.Rotate(0, angle, 0);
		}
	}
} 