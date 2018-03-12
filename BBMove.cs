using UnityEngine;
using System.Collections;
public class BBMove : MonoBehaviour
{

    public Vector3 from;
    public Vector3 to;



    public float TimeUse;

    private float EndTime = 0;

    private float sp;

    Vector3 v3;

    // Use this for initialization
    void Start()
    {
        sp = Vector3.Distance(from, to) / TimeUse;
        v3 = (to - from).normalized;

    }

    // Update is called once per frame
    void Update()
    {
        // EndTime += sp * Time.deltaTime * 0.1f;

        //transform.position = Vector3.Lerp(this.from, this.to, EndTime);

        transform.position += v3 * sp * Time.deltaTime;
    }
}