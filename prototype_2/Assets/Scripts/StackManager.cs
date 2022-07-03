using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] private float distanceBetweenObjects;   //parent'�n child�,2 pick aras�ndaki mesafe bbu picklerin y si kadar olmal�
    [SerializeField] private Transform prevObject;   //�nceki obje
    [SerializeField] private Transform parent;
   
    Rigidbody rigi;
    bool left;
    bool right;
    public float speed = 2.0f;
    public float rlspeed = 3.0f;
    public float jump = 4.0f;
    public Animator animator;
   
    //public float MaxVelocity;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        distanceBetweenObjects = prevObject.localScale.y;  //�nceki objenin ysi,parentn child objesi
        rigi = GetComponent<Rigidbody>();
      

    }

    public void PickUp(GameObject pickedObject, bool needTag = false, string tag = null, bool downOrUp = true)  //PickUp:toplamak, pickedObject:�arpt���m�z obje
    {
        if (needTag)
        {
            pickedObject.tag = tag;
        }
        pickedObject.transform.parent = parent;  //�arp�lan objeyi parent�n i�ine at
        Vector3 desPos = prevObject.localPosition;
        desPos.y += downOrUp ? distanceBetweenObjects : -distanceBetweenObjects;  //if else k�sa kullan�m�

        pickedObject.transform.localPosition = desPos;

        prevObject = pickedObject.transform;
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);

        Vector3 goRight = new Vector3(4.0f, transform.position.y, transform.position.z);
        Vector3 goLeft = new Vector3(-3.0f, transform.position.y, transform.position.z);

        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);

            if (finger.deltaPosition.x > 50.0f)
            {
                right = true;
                left = false;
            }
            if (finger.deltaPosition.x < -50.0f)
            {
                right = false;
                left = true;
            }
            else
            {
                if (finger.deltaPosition.y > 50.0f) //yukar� do�ru 50 piksellik dokunma olursa, 
                {
                   
                    rigi.velocity = Vector3.zero;
                    rigi.velocity = Vector3.up * jump;   //yukar� do�ru g�� uygula
                    //Debug.Log(gameObject.GetComponent<Rigidbody>().velocity.y);
                    animator.SetTrigger("JUMPAN�M");

                }

            }

            if (right)
            {
                transform.position = Vector3.Lerp(transform.position, goRight, rlspeed * Time.deltaTime);


            }

            if (left)
            {
                transform.position = Vector3.Lerp(transform.position, goLeft, rlspeed * Time.deltaTime);


            }
        }

    }
}

