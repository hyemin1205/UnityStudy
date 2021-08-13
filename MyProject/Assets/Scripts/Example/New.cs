using UnityEngine;

public class New : MonoBehaviour
{
    void Start(){
        int a = 10;
        int b = 2;

        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);        

        Debug.Log(a % b);

        bool t = true;
        bool f = false;
        Debug.Log(t && f);
        Debug.Log(t || f);
        Debug.Log(!t);

    }
}
