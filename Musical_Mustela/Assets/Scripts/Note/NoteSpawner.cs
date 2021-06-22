using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NoteSpawner : MonoBehaviour
{
    public Lev1 Lvl1;
    public static int endit;

    //Instantiating Game Object
    public GameObject Note;
    //Instantiate cooldown float
    public float Cooldown;
    //Instantiate canvas for text
    public Transform Canvas;

    //Instantiate function to spawn the note
    private void SpawnTheNote()
    {
        GameObject NoteSpawner = Instantiate(Note) as GameObject;
        NoteSpawner.transform.SetParent(Canvas);
        NoteSpawner.transform.position = new Vector2(8, 2.4318f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        Lvl1 = new Lev1();
        endit = Lvl1.NoteSequence.Length;
        Debug.Log(endit);
        Canvas = GameObject.FindGameObjectWithTag("TextCanvas").transform;
        StartCoroutine(CreateNewNote());
    }

    void Update()
    {
        if (endit <= 0)
        {
            ColDetect.WinitSwitch();
            Debug.Log(ColDetect.winit);
            ColDetect.Wincheck();
        }
    }
    IEnumerator CreateNewNote()
    {
        // Cooldown is in ms
        foreach(float n in Lvl1.NoteSequence)
        {
            Cooldown =  n / 1000;
            yield return new WaitForSeconds(Cooldown);
            SpawnTheNote();
        }
    }
}
