using UnityEngine;

public class testingScript : MonoBehaviour
{
    //oyun başlamadan önce 1 kere çalışır
    void Awake()
    {
        Debug.Log("Awake");

    }

    //oyun başlarken 1 kere çalışır
    void Start()
    {
        Debug.Log("Start");

    }

    void Update()
    {
        Debug.Log("Update");
    }

    void FixedUpdate()
    {

    }

    void LateUpdate()
    {
        
    }

}
