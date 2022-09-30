using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    public int jumpMultifier = 300;
    public float speed = 2;             //topun hareket hızı


    public bool isGround;

    GameObject cam;

    Rigidbody rb;            




    //BU KOD TOPUN KLAVYE İLE KONTROLÜNÜ SAĞLAMAKTADIR

    private void Start()
    {
        Time.timeScale = 1;
        cam = Camera.main.gameObject;
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        

        Vector3 direction =
            cam.transform.forward * Input.GetAxis("Vertical") +
            cam.transform.right * Input.GetAxis("Horizontal");

        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);



        if (isGround)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpMultifier);
            }
        }






    }

    public void Jumping()
    {
        if (isGround)
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpMultifier);       //bu kod kusursuz çalışıyor
        }
    }





    public void SpeedUp()
    {
        Vector3 direction =
            cam.transform.forward * Input.GetAxis("Vertical") +
            cam.transform.right * Input.GetAxis("Horizontal");

        rb.AddForce(direction * 1000 * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }



    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
}
