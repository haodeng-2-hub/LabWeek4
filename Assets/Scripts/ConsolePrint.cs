using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int i;

    void Start()
    {
        i = 3;
    }

    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name + ":" + i);
    }
}
