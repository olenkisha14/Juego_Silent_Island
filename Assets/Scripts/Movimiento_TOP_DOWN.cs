using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_TOP_DOWN : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Vector2 direccion;
    [SerializeField] private float initialEnergy = 10f;
    [SerializeField] private AudioClip caminarSonido;
    [SerializeField] private AudioSource audioSource;
    [SerializeField][Range(0f, 1f)] private float volumenCaminar = 0.5f;

    private float currentEnergy;
    private Rigidbody2D rb2D;

    private float movimientoX;
    private float movimientoY;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        currentEnergy = initialEnergy;
        //if (audioSource == null)
        //{
        //    audioSource = gameObject.AddComponent<AudioSource>();
        //    audioSource.clip = caminarSonido;
        //    audioSource.loop = true;
        //}
        audioSource.clip = caminarSonido;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
        audioSource.volume = volumenCaminar;
    }

    // Update is called once per frame
    void Update()
    {
        movimientoX = Input.GetAxisRaw("Horizontal");
        movimientoY = Input.GetAxisRaw("Vertical");
        animator.SetFloat("MovimientoX", movimientoX);
        animator.SetFloat("MovimientoY", movimientoY);
       
        if(movimientoX !=0 || movimientoY != 0)
        {
            animator.SetFloat("UltimoX", movimientoX);
            animator.SetFloat("UltimoY", movimientoY);
        }
        if (movimientoX != 0 || movimientoY != 0)
        {
            animator.SetFloat("UltimoX", movimientoX);
            animator.SetFloat("UltimoY", movimientoY);

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
        }

        direccion = new Vector2(movimientoX, movimientoY).normalized;
    }

    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + direccion * velocidadMovimiento * Time.fixedDeltaTime);
    }
}
