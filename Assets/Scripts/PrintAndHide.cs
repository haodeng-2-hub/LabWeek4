using UnityEngine;
public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i;
    void Start(){ i = 3; }
    void Update(){ i += 1; Debug.Log(gameObject.name + ":" + i); }
}
