using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i;
    int blueHideAt;

    void Start()
    {
        i = 3;
        if (CompareTag("Blue"))
        {
            blueHideAt = Random.Range(150, 251);
        }
    }

    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name + ":" + i);

        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (CompareTag("Blue") && i == blueHideAt)
        {
            if (rend != null) rend.enabled = false;
        }
    }
}
