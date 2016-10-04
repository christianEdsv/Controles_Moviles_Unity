using UnityEngine;
using System.Collections;

public class ControladorDeMovimiento : MonoBehaviour {

    // En esta variable configuraremos la velocidad a la que se moverá el objeto
    public float Velocidad;

    private bool derecha = false;
    private bool izquierda = false;

    //Variable que accede al rigibody de elemento a controlar
    Rigidbody rig;

    //Metodo Awake
    void Awake ()
    {
        //Obteniendo el componente Rigibody
        rig = GetComponent<Rigidbody>();
    }
    
	
	// Update is called once per frame
	void Update () {

        //Llamando al metodo para funcionabilidad con aceleromentro
        MovimientoAcelerometro();

        //Llamando al metodo para funcionabilidad touch
        //MovimientoTouch();

        //Moviendo el elemento con botones UI
        if (derecha)
        {
            // Movemos el objeto hacia la derecha
            this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
        }

        if (izquierda)
        {
            // Movemos el objeto hacia la izquierda
            this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }

	}

    void MovimientoAcelerometro()
    {
        float x = Input.acceleration.x;

        if(x < -0.1f)
        {
            TouchIzqda();
        }
        else if (x > 0.1f)
        {
            TouchDerecha();
        }
        else
        {
            VelocidadCero();    
        } 
    }

    // *****  Metodos para moviemiento touch  *****
    void MovimientoTouch()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            float midle = Screen.width / 2;

            if (touch.position.x < midle && touch.phase == TouchPhase.Began)
            {

                TouchIzqda();

            }
            else if (touch.position.x > midle && touch.phase == TouchPhase.Began)
            {

                TouchDerecha();
            }
        }

        else {
            VelocidadCero();
        }
    }

    public void TouchDerecha()
    {
        rig.velocity = new Vector2(Velocidad, 0);
    }

    public void TouchIzqda()
    {
        rig.velocity = new Vector2(-Velocidad, 0);
    }

    public void VelocidadCero()
    {
        rig.velocity = Vector2.zero;
    }

    // ***********************************************

    //Metodos para mover elemento con botones UI
    public void MoverDerecha()
    {
        derecha = true;
    }

    public void MoverIzqda()
    {
        izquierda = true;
    }

    public void Detener()
    {
        derecha = false;
        izquierda = false;
    }

}
