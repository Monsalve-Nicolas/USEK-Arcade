using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
     AudioSource source;
    public AudioClip fire, death, hurt, jump;
    private Player player;
    private Player2 player2;
    private InputManager input1;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        player = GetComponent<Player>();
        player2 = GetComponent<Player2>();
        input1 = GetComponent<InputManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            source.PlayOneShot(fire, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            source.PlayOneShot(jump, 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            source.PlayOneShot(fire, 1f);
        }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            source.PlayOneShot(jump, 1f);
        }

    }
   
}
