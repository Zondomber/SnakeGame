using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject PlayerCont;
    public float IceTime;
    private IObjectMover _objectMover;
    public int rotatplayer;
    public bool Die;
    public PlayerTrigger A_Stop;
    public PlayerTrigger D_Stop;
    public PlayerTrigger W_Stop;
    public PlayerTrigger S_Stop;

    public AudioSource RotateSound;
    public AudioSource DieSound;
    public AudioSource WorldSoundStart;
    public AudioSource WorldSoundEND;

    public GameObject TextE;

    public GameObject UI_Game;
    public GameObject UI_END;

    public GameObject Left;
    public GameObject Right;
    public GameObject Top;
    public GameObject Down;

    public GameObject EffectDie;

    void Start()
    {
        UI_Game.SetActive(true);
        UI_END.SetActive(false);

        _objectMover = GetComponent<IObjectMover>();
        Die = false;
        if (_objectMover != null)
            _objectMover.MoveForward();


    }


    public void Tel_Up()
    {
        RotateSound.Play();
        Top.SetActive(false);

        Down.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);

        rotatplayer = 4;
        
    }
    public void Tel_Down()
    {
        RotateSound.Play();
        Down.SetActive(false);

        Top.SetActive(true);
        Left.SetActive(true);
        Right.SetActive(true);

        rotatplayer = 2;
        
    }
    public void Tel_Right()
    {
        RotateSound.Play();
        Left.SetActive(false);

        Down.SetActive(true);
        Top.SetActive(true);
        Right.SetActive(true);

        rotatplayer = 1;
        
    }
    public void Tel_Left()
    {
        RotateSound.Play();
        Right.SetActive(false);

        Left.SetActive(true);
        Down.SetActive(true);
        Top.SetActive(true);

        rotatplayer = 3;
        
    }


    


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {
            DieSound.Play();
            WorldSoundStart.Stop();
            WorldSoundEND.Play();
            UI_Game.SetActive(false);
            UI_END.SetActive(true);
            EffectDie.SetActive(true);
            Die = true;
            Destroy(PlayerCont);
        }
        if (collision.tag == "SnakeBlock")
        {
            DieSound.Play();
            WorldSoundStart.Stop();
            WorldSoundEND.Play();
            UI_Game.SetActive(false);
            UI_END.SetActive(true);
            EffectDie.SetActive(true);
            Die = true;
            Destroy(PlayerCont);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && D_Stop.Triger == false)
        {
                rotatplayer = 3;
            
        }
        if (Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S) && A_Stop.Triger == false)
        {
                rotatplayer = 1;
            
        }
        if (Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && S_Stop.Triger == false)
        {
                rotatplayer = 4;
            
        }
        if (Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && W_Stop.Triger == false)
        {
                rotatplayer = 2;
            
        }



        if (_objectMover == null)
            return;

        if (rotatplayer == 4 && rotatplayer != 2 && W_Stop.Triger == false)
        {
            _objectMover.Rotate(Quaternion.Euler(0, 0, 90));
           
        }
        else if (rotatplayer == 2 && rotatplayer != 4 && S_Stop.Triger == false)
        {
            _objectMover.Rotate(Quaternion.Euler(0, 0, -90));
            
        }
        else if (rotatplayer == 1 && rotatplayer != 3 && D_Stop.Triger == false)
        {
            _objectMover.Rotate(Quaternion.Euler(0, 0, 0));
            
        }
        else if (rotatplayer == 3 && rotatplayer != 1 && A_Stop.Triger == false)
        {
            _objectMover.Rotate(Quaternion.Euler(0, 0, -180));
            
        }
    }
}

