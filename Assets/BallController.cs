using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;

    public void MoveBall(Vector2 input){
        Vector3 inputXZPlane = new Vector3(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }
}
