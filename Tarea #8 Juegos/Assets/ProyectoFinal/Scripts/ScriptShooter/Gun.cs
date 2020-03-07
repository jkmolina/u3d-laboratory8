using UnityEngine;
using UnityEngine.UI;
//using static UnityEngine.GraphicsBuffer;
//using static UnityEngine.GraphicsBuffer;

public class Gun : MonoBehaviour
{
    public Camera fpsCam;
    public int score;
    public GameObject scoreText;
    public int force;
    public int theScore;
    public AudioSource shoot;
    public AudioSource kill;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot.Play();
        }
        //Ray myRay = fpsCam.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(myRay, out hit))
        //{
        //    Debug.Log(hit.transform.name);

        //    if (hit.collider.tag == "Target")
        //    {

        //    }

        //}
    }

    void Shoot()
    {
    }
}
