using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float counter { get; private set; }
    public float knockback;
    Rigidbody rig;

    Vector3 pos;
    Vector3 lastpos;

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Asteroid")
        {
            counter++;
            if (counter == 11)
            {
                transform.localScale = new Vector3(1f, 1f, 1f);
            }

            else if (counter == 17)
            {
                transform.localScale = new Vector3 (1.2f,1.2f,1.2f);
            }
            else if (counter == 23)
            {
                SceneManager.LoadScene("winScene");
            }

            Destroy(hit.gameObject);
        }
    }

    void Start()
    {
        moveSpeed = 10f;
        knockback = 10f;
        rig = GetComponent<Rigidbody>();
        pos = transform.position;
    }

    public void KnockTheFuckBack()
    {

    }

    void Update()
    {

        var pos = new Vector3();
        pos.x = moveSpeed * Input.GetAxis("Horizontal");
        pos.z = moveSpeed * Input.GetAxis("Vertical");

        rig.velocity += pos * Time.deltaTime;
        rig.velocity = Vector3.ClampMagnitude(rig.velocity, 10);
        //rig.velocity = Vector3.zero;
        lastpos = pos;
    }
}