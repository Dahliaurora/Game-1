using UnityEngine;

public class Player_Script : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(direction*_playerSpeed*Time.deltaTime);
        Vector3 direction = new Vector3(horizontalInpt, verticalinput, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.96f, 0), 0);
    }
}
