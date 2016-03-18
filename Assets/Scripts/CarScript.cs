using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {
    [SerializeField]
    GameObject RightWhells;
    [SerializeField]
    GameObject LeftWhells;

    float TrainAngle;
    public float MultiBreak;
    public float MultiAccel;

	void Update () {
        Vector2 TrainAngle = transform.TransformDirection(Vector3.up);
        Vector2 InverseTrainAngle = transform.TransformDirection(Vector3.down);

        Debug.Log("Vetor direcao" + transform.TransformDirection(Vector3.down));

        GetComponent<Rigidbody2D>().AddForce(TrainAngle*MultiAccel);
        if (Input.GetAxis("Horizontal")>0) //botâo Direito
            GetComponent<Rigidbody2D>().AddForceAtPosition(InverseTrainAngle * MultiBreak, 
                RightWhells.transform.position);
        if (Input.GetAxis("Horizontal") < 0) //botâo Esquerdo
            GetComponent<Rigidbody2D>().AddForceAtPosition(InverseTrainAngle * MultiBreak, 
                LeftWhells.transform.position);
    }
}
