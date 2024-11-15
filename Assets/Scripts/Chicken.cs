using UnityEngine;

public class Chicken : MonoBehaviour
{
    Rigidbody rb;
    public static float speed = 1000.0f;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.linearVelocity = (-Vector3.forward) * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Shed")
        {
            ScoreManager.Instance.score++;
            Destroy(this.gameObject);
        }
        
    }
}
