using UnityEngine;
public class Move : MonoBehaviour {
    void Start () {
        Debug.Log("Start() called.");
	}
	void Update () {
        var dx = Input.GetAxis("Horizontal");
        var dz = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(dx, 0, dz));
	}
    private void OnTriggerEnter(Collider other) {
        Debug.LogFormat("OnTriggerEnter called. other is {0}", other.name);
    }
    private void OnTriggerExit(Collider other) {
        Debug.LogFormat("OnTriggerExit called. other is {0}", other.name);
    }
}
