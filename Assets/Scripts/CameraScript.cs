using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
    public GameObject player;
    private Transform cameraTarget;

    // Use this for initialization

    public void Start() {
        //pedreiro = GameObject.Find("Pedreiro");
        player = GameObject.FindGameObjectWithTag("Player");
        cameraTarget = player.transform;
        //maxXAndY = new Vector2(pedreiro.GetComponent<Mapa>().tamMapMax().x - 12.5f, pedreiro.GetComponent<Mapa>().tamMapMax().y - 7.0f);
        //minXAndY = new Vector2(pedreiro.GetComponent<Mapa>().tamMapMin().x + 12.5f, pedreiro.GetComponent<Mapa>().tamMapMin().y + 7.0f);
    }

    //bool CheckXMargin() {
    //    return Mathf.Abs(transform.position.x - cameraTarget.position.x) > xMargin;
    //}

    //bool CheckYMargin() {
    //    return Mathf.Abs(transform.position.y - cameraTarget.position.y) > yMargin;
    //}

    void FixedUpdate() {
        TrackPlayer();
    }

    void TrackPlayer() {
        //float targetX = transform.position.x;
        float targetY = transform.position.y;

        //if (CheckXMargin()) {
            //targetX = Mathf.Lerp(transform.position.x, cameraTarget.position.x, 1 * Time.deltaTime);
        //}

        //if (CheckYMargin()) {
            targetY = Mathf.Lerp(transform.position.y, cameraTarget.position.y, 1 * Time.deltaTime);
        //}

        //targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        //targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
    }
}
