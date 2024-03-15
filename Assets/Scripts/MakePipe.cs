using JetBrains.Annotations;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;

    float timer = 0;

    void Start()
    {
        timer = TimeDiff;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer>TimeDiff)
        {
           GameObject newPipe = Instantiate(pipe);
            newPipe. transform.position = new Vector3(3.83f, Random.Range(-3.35f, 0.81f), 0);
            timer = 0;

            Destroy(newPipe, 10.0f);
        }
    }
}
