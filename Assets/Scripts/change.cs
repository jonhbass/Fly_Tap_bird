using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class change : MonoBehaviour
{
    public string nomeDaCena;

    public void ChargeS (){
        SceneManager.LoadScene(nomeDaCena);
    }
}
