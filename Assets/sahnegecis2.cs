using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sahnegecis2 : MonoBehaviour
{ public void SonrakiSahne()
    {
        int sahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahne + 1);

    }
    public void bitti()
    {
        SceneManager.LoadScene(1);
    }

}
