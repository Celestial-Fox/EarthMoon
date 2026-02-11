using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private float velocityLimit = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        

        Thrust();   
        Rotate();
    }

    private void Thrust()
    {
        float vAxis = Input.GetAxis("Vertical");
        moveSpeed += vAxis * 0.1f;
        if (moveSpeed > velocityLimit)
        {
            moveSpeed = velocityLimit;
        }

        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        float hAxis = Input.GetAxis("Horizontal");

        transform.Rotate(0, hAxis , 0);  
    }
}
