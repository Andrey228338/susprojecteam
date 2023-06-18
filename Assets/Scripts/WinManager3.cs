using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinManager3 : MonoBehaviour
{
    [SerializeField] public GameObject Flag;
 
    void OnCollisionEnter(Collision killer)
    {
        
        {
            SceneManager.LoadScene(0);
        }
    }
}
