using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinManager2 : MonoBehaviour
{
    [SerializeField] public GameObject Flag;
 
    void OnCollisionEnter(Collision killer)
    {
        
        {
            SceneManager.LoadScene(4);
        }
    }
}
